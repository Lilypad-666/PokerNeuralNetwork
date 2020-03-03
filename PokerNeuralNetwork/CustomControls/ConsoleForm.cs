using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PokerNeuralNetwork {

    public partial class ConsoleForm : Form {

        private static ConsoleForm form = null;

        /// <summary>
        /// Creates the console
        /// </summary>
        public ConsoleForm() {
            InitializeComponent();

            form = this;

            //Allows dragging without a title bar
            ConsoleTitleBar.MouseDown += new MouseEventHandler(TitleBar);
            ConsoleLabel.MouseDown += new MouseEventHandler(TitleBar);

            //When loaded, calls function
            Load += Loaded;
        }

        /// <summary>
        /// Called when the box is fully loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Loaded(object sender, EventArgs e) {
            ConsoleExitButton.InitializeButton();

            //Call event when a key is pressed in the console input to check for an Enter or Arrow key
            ConsoleInput.KeyDown += new KeyEventHandler(ConsoleInputKeyDown);
            ConsoleSendButton.Click += new EventHandler(ConsoleSendClick);

            //Set the paint handler for adding images to the title bar
            ConsoleTitleBar.Paint += new PaintEventHandler(TitleBarPaint);
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

        delegate void ConsoleMessageCallback(string text, Color color);

        public static void ConsoleMessage(string text, Color color) {
            if (form != null) {
                if (form.RichConsoleText.InvokeRequired) {
                    ConsoleMessageCallback d = new ConsoleMessageCallback(ConsoleMessage);
                    form.Invoke(d, new object[] { text, color });
                } else {
                    form.RichConsoleText.SelectionColor = color;
                    form.RichConsoleText.AppendText(text);
                    SendMessage(form.Handle, WM_VSCROLL, (IntPtr)SB_BOTTOM, IntPtr.Zero);
                }
            }
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
            Stream myStream = myAssembly.GetManifestResourceStream("PokerNeuralNetwork.Resources.Keyboard.png");
            Bitmap bmp = new Bitmap(myStream);

            e.Graphics.DrawImage(bmp, 5f, 2.5f, 25, 25);
        }

        /// <summary>
        /// Triggers when the messagebox is being dragged, allows moving the box without a real title bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleBar(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
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