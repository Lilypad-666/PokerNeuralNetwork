using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PokerNeuralNetwork {

    /// <summary>
    /// Box that accepts keys as hotkeys
    /// </summary>
    public partial class PressAnyKeyBox : Form {

        /// <summary>
        /// The current hotkey that we're updating, see the hotkeys array above for meanings
        /// </summary>
        private int updatingHotkey;

        /// <summary>
        /// Required for designer
        /// </summary>
        public PressAnyKeyBox() {
            InitializeComponent();
        }

        /// <summary>
        /// Creates the hotkey box
        /// </summary>
        /// <param name="updatingHotkey">Hotkey that we're updating</param>
        public PressAnyKeyBox(int updatingHotkey) {
            InitializeComponent();

            //Lets the program see all keys
            KeyPreview = true;

            this.updatingHotkey = updatingHotkey;

            //Allows dragging without a title bar
            HotkeyTitleBar.MouseDown += new MouseEventHandler(TitleBar);
            HotkeyLabel.MouseDown += new MouseEventHandler(TitleBar);

            //When loaded, calls function
            Load += Loaded;
        }

        /// <summary>
        /// Called when the box is fully loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Loaded(object sender, EventArgs e) {
            HotkeyExitButton.InitializeButton();

            //Sets the labels and texts correctly
            string labelText = "";
            if (updatingHotkey == 0) {
                labelText = "Options";
                OptionsWarningLabel.Text = "Must be A-Z, 0-9, or F1-F24";
                OptionsWarningLabel.ForeColor = Color.Red;
            }

            if (updatingHotkey >= 1 && updatingHotkey <= 7) {
                labelText = "Script " + updatingHotkey;
            }

            labelText += " Hotkey";

            EditingHotkeyLabel.Text = labelText;

            //Set the paint handler for adding images to the title bar
            HotkeyTitleBar.Paint += new PaintEventHandler(TitleBarPaint);
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
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();
    }
}