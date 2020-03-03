using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PokerNeuralNetwork {

    /// <summary>
    /// The main form!
    /// </summary>
    public partial class MainForm : Form {

        /// <summary>
        /// Whether we're in debug mode or not
        /// </summary>
        public static bool debug;

        /// <summary>
        /// A reference to the main form if it's loaded
        /// </summary>
        private static MainForm form = null;

        /// <summary>
        /// Amount of chips for small blind
        /// </summary>
        private int smallBlind = 10;

        /// <summary>
        /// List of all the poker games
        /// </summary>
        private List<Poker.Holdem> pokerGames = new List<Poker.Holdem>(0);

        /// <summary>
        /// Creates the main form
        /// </summary>
        public MainForm() {
            InitializeComponent();

            form = this;

            //Creates the Data and log directories
            Directory.CreateDirectory("Data");
            Directory.CreateDirectory("Logs");

            //Doesn't allow resizing or maximizing of the window
            if (!debug) {
                FormBorderStyle = FormBorderStyle.None;
            }

            MaximizeBox = false;

            //Lets the program see keys even when it's not focused (for hotkeys)
            KeyPreview = true;

            //Disables all the tabs
            ToggleTabs();

            //Gets the version number
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            //Adds the version number to the title
            Text += version;
            TitleLabel.Text += version;

            //Adds events for others
            Load += new EventHandler(FormLoaded);
        }

        /// <summary>
        /// Triggers when the form is finished loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoaded(object sender, EventArgs e) {

            //Set the current tab as the first one
            MainTabControl.SelectedTab = GameTab;

            //Apply the link to the LinkLabels
            GitHubLink.Links.Add(0, 0, "https://github.com/Lilypad-666/PokerNeuralNetwork");
            GitHubLink.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkClicked);

            //Update the version label to include the current version number
            VersionNumberLabel.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            //Set the paint handler for adding images to the background
            DebuggingInfoPanel.Paint += new PaintEventHandler(InfoTabPaint);

            //Set the paint handler for adding images to the title bar
            TitleBarPanel.Paint += new PaintEventHandler(TitleBarPaint);

            //Call event when a key is pressed in the console input to check for an Enter or Arrow key
            ConsoleInput.KeyDown += new KeyEventHandler(ConsoleInputKeyDown);
            ConsoleSendButton.Click += new EventHandler(ConsoleSendClick);

            //Lets you drag around the window without a windows title bar
            TitleBarPanel.MouseDown += new MouseEventHandler(TitleBar);
            TitleLabel.MouseDown += new MouseEventHandler(TitleBar);

            //When either the SB or the Chip numbers are changed
            SBValue.ValueChanged += new EventHandler(SBValueChanged);
            ChipsValue.ValueChanged += new EventHandler(ChipsValueChanged);

            //Play new game
            NewGameButton.Click += new EventHandler(StartNewGame);

            DrawCheckBox.Cursor = Cursors.Default;
            DrawCheckBox.Loaded();
            DrawCheckBox.Click += CheckboxToggle;

            SBText.Cursor = Cursors.IBeam;
            ChipsText.Cursor = Cursors.IBeam;

            ExitButton.InitializeButton();
            MinimizeButton.InitializeButton();
        }

        /// <summary>
        /// Triggers when a checkbox is toggled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckboxToggle(object sender, EventArgs e) {
            //On checkbox toggle, save to the config
            CustomCheckBox box = (sender as CustomCheckBox);
            box.StartRotate();
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
            smallBlind = (int)SBValue.Value;
            Console.WriteLine("SB changed to " + smallBlind);
        }

        /// <summary>
        /// Handles dragging around the window without a windows title bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleBar(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }
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
            foreach (Poker.Holdem game in pokerGames) {
                if (game.finished) {
                    game.NewGame(10, 1500);
                    gameStarted = true;
                    break;
                }
            }

            if (!gameStarted) {
                Poker.Holdem game = new Poker.Holdem(6);
                pokerGames.Add(game);
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

            //If the string isn't blank and enter is pressed, send the command to the console
            if (e.KeyCode == Keys.Enter) {
                if (ConsoleInput.Text.Length > 0) {
                    Console.SendCommand(ConsoleInput.Text);
                    Console.previousCommands.Insert(0, ConsoleInput.Text);
                    ConsoleInput.Text = "";
                    Console.currentCommand = -1;
                }
            }

            //If up is pressed, shift one command up
            else if (e.KeyCode == Keys.Up) {
                if (Console.currentCommand != Console.previousCommands.Count - 1) {
                    Console.currentCommand++;
                    ConsoleInput.Text = Console.previousCommands[Console.currentCommand];
                }
            }

            //Else if down is pressed, shift one command back
            else if (e.KeyCode == Keys.Down) {
                if (Console.currentCommand <= 0) {
                    Console.currentCommand = -1;
                    ConsoleInput.Text = "";
                    return;
                }

                Console.currentCommand--;
                ConsoleInput.Text = Console.previousCommands[Console.currentCommand];
            }
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

        public static void ConsoleMessage(string text, Color color) {
            if (form != null) {
                form.RichConsoleText.SelectionColor = color;
                form.RichConsoleText.AppendText(text);
                SendMessage(form.Handle, WM_VSCROLL, (IntPtr)SB_BOTTOM, IntPtr.Zero);
            }
        }

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        private const int WM_VSCROLL = 0x115;
        private const int SB_BOTTOM = 7;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();
    }
}