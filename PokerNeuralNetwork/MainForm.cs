using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PokerNeuralNetwork {

    /// <summary>
    /// The main form!
    /// </summary>
    public partial class MainForm : Form {


        /// <summary>
        /// Timer that runs to ensure that the game is still running and valid
        /// </summary>
        private Timer updateTimer;

        public static bool loaded = false;

        /// <summary>
        /// Creates the main form
        /// </summary>
        public MainForm() {
            InitializeComponent();

            Data.form = this;

            //Creates the Data and log directories
            Directory.CreateDirectory("Data");
            Directory.CreateDirectory("Logs");

            //Doesn't allow resizing or maximizing of the window
            if (!Info.debug) {
                FormBorderStyle = FormBorderStyle.None;
            }

            MaximizeBox = false;

            //Lets the program see keys even when it's not focused (for hotkeys)
            KeyPreview = true;

            //Crates a new HookedWindow
            Data.window = new HookedWindow();

            //Disables all the tabs
            ToggleTabs();

            //Gets the version number
            Info.version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            //Adds the version number to the title
            Text += Info.version;
            TitleLabel.Text += Info.version;

            //Adds events for others
            Load += new EventHandler(FormLoaded);

            Functions.LoadData();
        }

        /// <summary>
        /// Triggers when the form is finished loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoaded(object sender, EventArgs e) {

            loaded = true;

            //Start the timer once the form is loaded
            InitTimer();

            //Set the current tab as the first one
            MainTabControl.SelectedTab = GameTab;

            //Apply the link to the LinkLabels
            GitHubLink.Links.Add(0, 0, "https://github.com/Lilypad-666/PokerNeuralNetwork");
            GitHubLink.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkClicked);

            //Update the version label to include the current version number
            VersionNumberLabel.Text = Info.version;

            //Set the paint handler for adding images to the background
            DebuggingInfoPanel.Paint += new PaintEventHandler(InfoTabPaint);

            //Set the paint handler for adding images to the title bar
            TitleBarPanel.Paint += new PaintEventHandler(TitleBarPaint);

            //Call event when the text is changed in the process name field
            //ProcessName.TextChanged += new EventHandler(ProcessTextChanged);

            //Call event when a key is pressed in the console input to check for an Enter or Arrow key
            ConsoleInput.KeyDown += new KeyEventHandler(ConsoleInputKeyDown);
            ConsoleSendButton.Click += new EventHandler(ConsoleSendClick);

            //Update the two delays
            //SearchDelayInput.ValueChanged += new EventHandler(DelayInputValueChanged);
            //UpdateDelayInput.ValueChanged += new EventHandler(DelayInputValueChanged);

            //Lets you drag around the window without a windows title bar
            TitleBarPanel.MouseDown += new MouseEventHandler(TitleBar);
            TitleLabel.MouseDown += new MouseEventHandler(TitleBar);

            //When either the SB or the Chip numbers are changed
            SBValue.ValueChanged += new EventHandler(SBValueChanged);
            ChipsValue.ValueChanged += new EventHandler(ChipsValueChanged);

            //Play new game
            NewGameButton.Click += new EventHandler(StartNewGame);

            ExitButton.InitializeButton();
            MinimizeButton.InitializeButton();
        }

        /// <summary>
        /// Triggered when the "Chips" numeric up/down is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChipsValueChanged(object sender, EventArgs e) {
            //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //config.AppSettings.Settings["chipValue"].Value = (int)ChipsValue.Value;
            //Console.WriteLine("Chips changed to " + Data.chipSize);
        }

        /// <summary>
        /// Triggered when the "SB" numeric up/down is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SBValueChanged(object sender, EventArgs e) {
            Data.smallBlind = (int)SBValue.Value;
            Console.WriteLine("SB changed to " + Data.smallBlind);
        }

        /// <summary>
        /// Handles dragging around the window without a windows title bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleBar(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /// <summary>
        /// Triggers when the vaule of either delay inputs are changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelayInputValueChanged(object sender, EventArgs e) {
            NumericUpDown input = sender as NumericUpDown;

            if (input.Name.Contains("Search")) {
                Info.searchDelay = decimal.ToInt32(input.Value);

                Data.settings[1] = Info.searchDelay;
            }

            if (input.Name.Contains("Update")) {
                Info.updateDelay = decimal.ToInt32(input.Value);
                Data.settings[2] = Info.updateDelay;
            }

            Data.Save("settings.dat", Data.settings);
            UpdateTimerDelay();
        }

        /// <summary>
        /// Triggers when a link is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            LinkLabel link = sender as LinkLabel;

            Process.Start(link.Links[0].LinkData.ToString());
        }

        /// <summary>
        /// Triggers when the processing text box gets changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessTextChanged(object sender, EventArgs e) {
            TextBox box = sender as TextBox;

            //Make the text lower case
            box.Text = box.Text.ToLower();

            //Store the text into settings
            Data.settings[0] = box.Text;

            //Save the new process to file
            Data.Save("settings.dat", Data.settings);

            //Clear the current window and reset everything
            Data.window.Clear();
            RestoreWindowInfoDefault();
            Info.foundGame = false;
            Info.isFocusedWindow = false;

            UpdateTimerDelay();

            ToggleTabs();
        }

        /// <summary>
        /// Triggers when the Info tab needs to get repained. Allows me to draw images.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoTabPaint(object sender, PaintEventArgs e) {
            //Draws the images on the program info tab
            Graphics g = e.Graphics;
            g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("PokerNeuralNetwork.Resources.lilypad1.png");
            Bitmap bmp = new Bitmap(myStream);

            e.Graphics.DrawImage(bmp, 250, 250, bmp.Width, bmp.Height);
        }

        /// <summary>
        /// Triggers when the Title Bar tab needs to get repained. Allows me to draw images.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleBarPaint(object sender, PaintEventArgs e) {
            //Draws the images on the program info tab
            Graphics g = e.Graphics;
            g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("PokerNeuralNetwork.Resources.Cloak.png");
            Bitmap bmp = new Bitmap(myStream);

            e.Graphics.DrawImage(bmp, 5f, 2.5f, 25, 25);
        }

        /// <summary>
        /// Runs every Data.timerDelay ms, verifies that our program is still running and searches for it if it isn't
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateTimerTick(object sender, EventArgs e) {

            //When the timer ticks, update the window's location
            UpdateHookedWindow();

            Info.isFocusedWindow = Data.window.IsFocusedWindow();
        }

        /// <summary>
        /// Triggers when the change hotkey button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HotkeyButtonClick(object sender, EventArgs e) {
            Button button = sender as Button;
            //Get the index from the regex \d+, which grabs the number at the end of the string
            SetHotkey(int.Parse(Regex.Match(button.Name, @"\d+").Value));
        }

        /// <summary>
        /// Triggers when the send button is pressed on the console
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsoleSendClick(object sender, EventArgs e) {
            ConsoleInputKeyDown(sender, new KeyEventArgs(Keys.Enter));
        }

        /// <summary>
        /// Triggers when the send button is pressed on the console
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartNewGame(object sender, EventArgs e) {
            //PLAYER COUNT
            int players = 6;

            //Hide start button
            NewGameButton.Enabled = false;
            NewGameButton.Visible = false;

            TableLayoutPanel[] panels = new TableLayoutPanel[players + 1];

            panels[0] = PlayerLayout0;
            panels[1] = PlayerLayout1;
            panels[2] = PlayerLayout2;
            panels[3] = PlayerLayout3;
            panels[4] = PlayerLayout4;
            panels[5] = PlayerLayout5;
            panels[6] = MiddlePanel;

            //Start game in new thread
            CreateNewGame();
        }

        private void CreateNewGame() {

            bool gameStarted = false;
            foreach (Poker.Holdem game in Data.games) {
                if (game.finished) {
                    game.NewGame(10, 1500);
                    gameStarted = true;
                    break;
                }
            }

            if (!gameStarted) {
                Poker.Holdem game = new Poker.Holdem(6);
                Data.games.Add(game);
                game.NewGame(10, 1500);
            }
        }

        /// <summary>
        /// Triggered when a key is pressed while in the console
        /// Handles keyboard controls for the console
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsoleInputKeyDown(object sender, KeyEventArgs e) {
            Properties.Settings settings = Properties.Settings.Default;

            //If the string isn't blank and enter is pressed, send the command to the console
            if (e.KeyCode == Keys.Enter) {
                if (ConsoleInput.Text.Length > 0) {
                    Console.SendCommand(ConsoleInput.Text);
                    Data.previousCommands.Insert(0, ConsoleInput.Text);
                    ConsoleInput.Text = "";
                    settings.currentCommand = -1;
                }
            }

            //If up is pressed, shift one command up
            else if (e.KeyCode == Keys.Up) {
                if (settings.currentCommand != Data.previousCommands.Count - 1) {
                    settings.currentCommand++;
                    ConsoleInput.Text = Data.previousCommands[settings.currentCommand];
                }
            }

            //Else if down is pressed, shift one command back
            else if (e.KeyCode == Keys.Down) {
                if (settings.currentCommand <= 0) {
                    settings.currentCommand = -1;
                    ConsoleInput.Text = "";
                    return;
                }

                settings.currentCommand--;
                ConsoleInput.Text = Data.previousCommands[settings.currentCommand];
            }
        }

        /// <summary>
        /// Updates the timer to the correct delay
        /// </summary>
        public void UpdateTimerDelay() {
            if (updateTimer != null) {
                //If we are in the game
                if (Info.foundGame) {
                    //Verify that the current delay is the update delay
                    if (Info.currentDelay != Info.updateDelay) {
                        //If it isn't set the interval to be the update delay
                        Info.currentDelay = Info.updateDelay;
                        updateTimer.Stop();
                        updateTimer.Interval = Info.updateDelay;
                        updateTimer.Start();

                        //Print out that we changed the delay
                        Console.WriteLine("Changed current delay to " + Info.currentDelay + "ms.");
                    }
                } else {
                    //Verify that the current delay is the search delay
                    if (Info.currentDelay != Info.searchDelay) {
                        //If it isn't, set the interval to be the search delay
                        Info.currentDelay = Info.searchDelay;
                        updateTimer.Stop();
                        updateTimer.Interval = Info.searchDelay;
                        updateTimer.Start();

                        //Print out that we changed the delay
                        Console.WriteLine("Changed current delay to " + Info.currentDelay + "ms.");
                    }
                }
            }
        }

        /// <summary>
        /// Starts the timer for the update
        /// </summary>
        private void InitTimer() {
            //Creates a timer on a x ms interval
            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Tick += new EventHandler(UpdateTimerTick);
            updateTimer.Interval = Info.searchDelay;
            updateTimer.Start();
        }

        /// <summary>
        /// Toggles whether the tabs are enabled, given foundGame
        /// </summary>
        private void ToggleTabs() {
            //If the active tab isn't the Debugging tab or the Main tab, set the active tab to the Main tab
            if (MainTabControl.SelectedTab != GameTab && MainTabControl.SelectedTab != DebuggingTab) {
                MainTabControl.ForceTabSwitch(GameTab);
            }

            MainTabControl.Refresh();
        }

        /// <summary>
        /// Restores the window info back to N/A and Not Found.
        /// </summary>
        private void RestoreWindowInfoDefault() {
            WindowXBox.Text = "N/A";
            WindowYBox.Text = "N/A";
            WindowWidthBox.Text = "N/A";
            WindowHeightBox.Text = "N/A";
            //ProgramProcess.Text = "Not Found...";
        }

        /// <summary>
        /// Disables the window and sets the current hotkey that we're updating
        /// </summary>
        /// <param name="index">Index of the hotkey that's being changed</param>
        public void SetHotkey(int index) {
            //Disables the window until the hotkey is set
            using (var form = new PressAnyKeyBox(index)) {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Verifies that the window is a valid process, and attempts to find the valid process if it isn't
        /// Handles the text box/ui side of it
        /// </summary>
        private void UpdateHookedWindow() {
            //If the window is no longer a valid process
            if (!Data.window.ValidprogramProcess()) {
                //Try to find the new program window
                if (Data.window.FindprogramProcess()) {
                    //If the process is found but the window handle isn't, don't enable anything
                    if (Data.window.GetWindowName() == "") {
                        Info.foundGame = false;
                        Info.isFocusedWindow = false;
                        return;
                    }

                    //If found, set the text and enable the panels and tabs
                    //ProgramProcess.Text = Data.window.GetWindowName();

                    Info.foundGame = true;
                    Info.toggleTabs = true;

                    Console.WriteLine("Found window: " + Data.window.GetWindowName());

                    //Verify that the delay is at the updateDelay speed
                    UpdateTimerDelay();
                } else {
                    RestoreWindowInfoDefault();

                    Info.foundGame = false;
                    Info.toggleTabs = true;
                    Info.isFocusedWindow = false;

                    //Verify that the delay is at the searchDelay speed
                    UpdateTimerDelay();
                }
            } else {
                //The window is still a valid process, so verify that the Data.window's dimensions are correct
                //We don't care about x and y because the clicks are all relative
                Data.window.UpdateWindowRect();

                //Update the given info on the screen
                WindowXBox.Text = Data.window.GetX().ToString();
                WindowYBox.Text = Data.window.GetY().ToString();
                WindowWidthBox.Text = Data.window.GetWidth().ToString();
                WindowHeightBox.Text = Data.window.GetHeight().ToString();
            }
        }

        /// <summary>
        /// Creates a new tab in the tabControl from the uc template.
        /// </summary>
        /// <param name="tabControl">Name of the tabControl to add the tab to</param>
        /// <param name="uc">Template to copy over to the new tab</param>
        /// <param name="index">Index of the new tab</param>
        /// <returns></returns>
        public static TabPage CreateTab(CustomTabControl tc, CustomUserControl template, int index) {
            //Creates an "adjusted index" based on the index (0-7) and the offset
            int adjustedIndex = index + template.offset;

            TabPage tp = new TabPage();

            template.Name += (index + 1);

            //Copy all the Data from the template to the new tab
            tp.Controls.Add(template);

            //Sets the text and name
            tp.Text = "Script " + (index + 1);
            tp.Name = "Script" + adjustedIndex;

            //Allows 7 tabs (0-6) of any given type
            if (index >= 6) {
                if (template is UserControl) {
                    Button button = FindControl<Button>(tp, "AddScript");
                    button.Enabled = false;
                    button.BackColor = Color.Gray;
                }
            }

            //Adds the tab to the tab control
            tc.TabPages.Add(tp);

            //Sets the tab as the currently active tab
            tc.ForceTabSwitch(tp);

            Console.WriteLine("Successfully created tab index " + adjustedIndex);

            return tp;
        }

        /// <summary>
        /// Recursively finds the first child of the given name
        /// Includes children of children
        /// </summary>
        /// <param name="root">Control to be the top parent</param>
        /// <param name="name">Name to search for</param>
        /// <param name="childrenOfChildren">Whether to recursively search or not</param>
        /// <returns>The first instance found of T with name</returns>
        public static T FindControl<T>(Control root, string name, bool childrenOfChildren = true) where T : Control {

            //If root's name matches, return it
            if (root is T && root.Name.Equals(name)) {
                return (root as T);
            }

            //Run through each child in this root's controls
            foreach (Control c in root.Controls) {
                if (childrenOfChildren) {
                    //Recursively call the function on each child
                    T t = FindControl<T>(c, name);

                    //If we found a match, return it
                    if (t != null) {
                        return t;
                    }
                } else {
                    //If the name matches, return it
                    if (c is T && c.Name.Equals(name)) {
                        return (c as T);
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Recursively finds all children who's names contain the given name
        /// </summary>
        /// <param name="root">Control to be the top parent</param>
        /// <param name="name">Name to search for</param>
        /// <param name="childrenOfChildren">Whether to recursively search or not</param>
        /// <returns>A list of all instances of T who's name contain name</returns>
        public static List<T> FindControls<T>(Control root, string name = "", bool childrenOfChildren = true) where T : Control {

            List<T> list = new List<T>();

            //If root's name contains, add it to the list
            if (root is T && root.Name.Contains(name)) {
                list.Add(root as T);
            }

            //Run through each child in this root's controls
            foreach (Control c in root.Controls) {
                if (childrenOfChildren) {
                    //Recursively call the function on each child
                    list.AddRange(FindControls<T>(c, name));
                } else {
                    //If the name matches, return it
                    if (c is T && c.Name.Contains(name)) {
                        list.Add(c as T);
                    }
                }
            }

            return list;
        }

        public static void SetConsoleLogColor(Color color) {

        }

        public static void ConsoleAppendText(string text) {

        }

        public static IntPtr ConsoleHandle() {
            
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
    }
}