using Newtonsoft.Json;
using PokerNeuralNetwork.Poker;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerNeuralNetwork {

    /// <summary>
    /// The main form!
    /// </summary>
    public partial class MainForm : Form {

        /// <summary>
        /// Whether we're in debug mode or not
        /// </summary>
        public static bool Debug { get; set; }

        /// <summary>
        /// A reference to the main form if it's loaded
        /// </summary>
        private static MainForm form = null;

        /// <summary>
        /// A reference to the console popout
        /// </summary>
        private static ConsoleForm console = null;

        /// <summary>
        /// Incrementor for table ids
        /// </summary>
        private int tableIDs = 0;

        /// <summary>
        /// Amount of chips for small blind
        /// </summary>
        private int smallBlind = 10;
        private int SmallBlind {
            get {
                return smallBlind;
            }
            set {
                smallBlind = value;
                Data.Save(new SaveData() {
                    ConsolePopOut = form.ConsolePopoutCheckbox.Checked,
                    SmallBlind = SmallBlind,
                    StartingChips = StartingChips,
                    Players = Players
                });
            }
        }

        /// <summary>
        /// Number of starting chips
        /// </summary>
        private int startingChips = 1500;
        private int StartingChips {
            get {
                return startingChips;
            }
            set {
                smallBlind = value;
                Data.Save(new SaveData() {
                    ConsolePopOut = form.ConsolePopoutCheckbox.Checked,
                    SmallBlind = SmallBlind,
                    StartingChips = StartingChips,
                    Players = Players
                });
            }
        }

        /// <summary>
        /// Number of players
        /// </summary>
        private int players = 6;
        private int Players {
            get {
                return players;
            }
            set {
                players = value;
                Data.Save(new SaveData() {
                    ConsolePopOut = form.ConsolePopoutCheckbox.Checked,
                    SmallBlind = SmallBlind,
                    StartingChips = StartingChips,
                    Players = Players
                });
            }
        }

        /// <summary>
        /// Random object for generating random numbers
        /// </summary>
        private Random rng;

        /// <summary>
        /// Creates the main form
        /// </summary>
        public MainForm() {
            InitializeComponent();

            //Sets the static form var to this instance
            form = this;

            //Create the popout console window
            console = new ConsoleForm();

            //Creates a new Random object
            rng = new Random();

            //Creates the Data and log directories
            Directory.CreateDirectory("Data");
            Directory.CreateDirectory("Logs");

            //Doesn't allow resizing or maximizing of the window
            FormBorderStyle = FormBorderStyle.None;

            MaximizeBox = false;

            //Lets the program see keys even when it's not focused (for hotkeys)
            KeyPreview = true;

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
            MainTabControl.SelectedTab = MainTab;

            //Apply the link to the LinkLabels
            GitHubLink.Links.Add(0, 0, "https://github.com/Lilypad-666/PokerNeuralNetwork");
            GitHubLink.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkClicked);

            //Update the version label to include the current version number
            VersionNumberLabel.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            //Set the paint handler for adding images to the background
            DebuggingInfoPanel.Paint += new PaintEventHandler(InfoTabPaint);

            //Set the paint handler for adding images to the title bar
            TitleBarPanel.Paint += new PaintEventHandler(TitleBarPaint);

            //Lets you drag around the window without a windows title bar
            TitleBarPanel.MouseDown += new MouseEventHandler(TitleBar);
            TitleLabel.MouseDown += new MouseEventHandler(TitleBar);

            //When one of the settings is changed
            SBValue.ValueChanged += new EventHandler(SBValueChanged);
            ChipsValue.ValueChanged += new EventHandler(ChipsValueChanged);
            PlayersValue.ValueChanged += new EventHandler(PlayersValueChanged);

            //Call event when a key is pressed in the console input to check for an Enter or Arrow key
            ConsoleInput.KeyDown += new KeyEventHandler(ConsoleInputKeyDown);
            ConsoleSendButton.Click += new EventHandler(ConsoleSendClick);

            //Scroll when rich text box changed
            RichConsoleText.TextChanged += new EventHandler(ConsoleTextChanged);

            //Play new game
            StartHoldemButton.Click += new EventHandler(StartNewGame);

            VisualTab.Enabled = false;
            SettingsTab.Enabled = false;

            ConsolePopoutCheckbox.Cursor = Cursors.Hand;
            ConsolePopoutCheckbox.Loaded();
            ConsolePopoutCheckbox.Click += ConsoleCheckboxToggle;

            SBText.Cursor = Cursors.IBeam;
            ChipsText.Cursor = Cursors.IBeam;

            //ThreadPool.SetMinThreads(4, 4);
            ThreadPool.SetMaxThreads(16, 16);

            ExitButton.InitializeButton();
            MinimizeButton.InitializeButton();

            SaveData data = Data.Load();

            Console.WriteLine(JsonConvert.SerializeObject(data));

            if (data != null) {
                bool boxChecked = data.ConsolePopOut;
                this.ConsolePopoutCheckbox.Checked = boxChecked;

                if (boxChecked) {
                    ConsoleTab.Enabled = false;
                    console.Show();
                } else {
                    ConsoleTab.Enabled = true;
                    console.Hide();
                }

                this.SBValue.Value = data.SmallBlind;
                this.ChipsValue.Value = data.StartingChips;
                this.PlayersValue.Value = data.Players;
            }
        }

        /// <summary>
        /// Triggers when a checkbox is toggled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsoleCheckboxToggle(object sender, EventArgs e) {
            CustomCheckBox box = (sender as CustomCheckBox);

            box.StartRotate();

            if (box.Checked) {
                ConsoleTab.Enabled = false;
                console.Show();
            } else {
                ConsoleTab.Enabled = true;
                console.Hide();
            }

            MainTabControl.Refresh();

            Data.Save(new SaveData() {
                ConsolePopOut = box.Checked,
                SmallBlind = smallBlind,
                StartingChips = startingChips,
                Players = players
            });
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
        /// Triggers when the send button is pressed on the console
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsoleSendClick(object sender, EventArgs e) {
            ConsoleInputKeyDown(sender, new KeyEventArgs(Keys.Enter));
        }

        /// <summary>
        /// Triggers when the console text is changed
        /// Scrolls the console to the bottom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ConsoleTextChanged(object sender, EventArgs e) {
            RichConsoleText.SelectionStart = RichConsoleText.Text.Length;
            RichConsoleText.ScrollToCaret();
        }

        /// <summary>
        /// Triggered when the "Chips" numeric up/down is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChipsValueChanged(object sender, EventArgs e) {
            StartingChips = (int)ChipsValue.Value;
        }

        /// <summary>
        /// Triggered when the "SB" numeric up/down is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SBValueChanged(object sender, EventArgs e) {
            SmallBlind = (int)SBValue.Value;
        }

        /// <summary>
        /// Triggered when the "Players" numeric up/down is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayersValueChanged(object sender, EventArgs e) {
            Players = (int)PlayersValue.Value;
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
        private void StartNewGame(object sender, EventArgs e) {
            //PLAYER COUNT
            int players = 6;

            //Hide start button
            StartHoldemButton.Enabled = false;

            TableLayoutPanel[] panels = new TableLayoutPanel[players + 1];

            panels[0] = PlayerLayout0;
            panels[1] = PlayerLayout1;
            panels[2] = PlayerLayout2;
            panels[3] = PlayerLayout3;
            panels[4] = PlayerLayout4;
            panels[5] = PlayerLayout5;
            panels[6] = MiddlePanel;

            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 1000; i++) {
                CreateNewGame();
            }
            timer.Stop();
            Console.WriteLine(timer.ElapsedTicks);
        }

        /// <summary>
        /// Create a new Poker
        /// </summary>
        private void CreateNewGame() {
            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate (object state) {
                Holdem game = new Holdem(tableIDs++, rng.Next());
                game.NewGame(players, smallBlind, startingChips);
            }));
        }

        delegate void ConsoleMessageCallback(string text, Color color);

        public static void ConsoleMessage(string text, Color color) {
            if (form != null) {
                ConsoleForm.ConsoleMessage(text, color);

                if (form.RichConsoleText.InvokeRequired) {
                    ConsoleMessageCallback d = new ConsoleMessageCallback(ConsoleMessage);
                    form.Invoke(d, new object[] { text, color });
                } else {
                    form.RichConsoleText.SelectionColor = color;
                    form.RichConsoleText.AppendText(text);
                    //SendMessage(form.Handle, WM_VSCROLL, (IntPtr)SB_BOTTOM, IntPtr.Zero);
                }
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