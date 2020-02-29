using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PokerNeuralNetwork {

    /// <summary>
    /// The window that the process is running on
    /// </summary>
    public class HookedWindow {

        /// <summary>
        /// Process of the program
        /// </summary>
        private Process programProcess = null;

        /// <summary>
        /// Handle of the window of the program
        /// </summary>
        private IntPtr programHandle;

        /// <summary>
        /// Rectangle of the window of the program
        /// </summary>
        private Rectangle programRect;

        /// <summary>
        /// Name of the program
        /// </summary>
        private string programName = "";

        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYUP = 0x101;
        private const int WM_CHAR = 0x105;

        /// <summary>
        /// Resets everything back to default
        /// </summary>
        public void Clear() {
            programProcess = null;
            programHandle = IntPtr.Zero;
            programRect = new Rectangle();
            programName = "";
        }

        /// <summary>
        /// Returns true if the focused window is the one we want
        /// </summary>
        /// <returns></returns>
        public bool IsFocusedWindow() {
            string title = GetActiveWindowTitle();

            if (title != null) {
                return title.Equals(programName);
            }

            return false;
        }

        /// <summary>
        /// Returns the title of the currently active window
        /// </summary>
        /// <returns></returns>
        private string GetActiveWindowTitle() {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0) {
                return Buff.ToString();
            }
            return null;
        }

        /// <summary>
        /// Returns whether the current program process is valid
        /// </summary>
        /// <returns></returns>
        public bool ValidprogramProcess() {
            //If the program process is null or has exited
            if (programProcess == null || programProcess.HasExited) {
                return false;
            }

            //Or if the name is empty
            if (programName == "") {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Attempts to locate the running program
        /// </summary>
        /// <returns></returns>
        public bool FindprogramProcess() {
            //Force the process name to be something
            if (((string)Data.settings[0]).Length < 1) {
                return false;
            }

            return false;

            //Disabled until I need to be able to find a program's process
#pragma warning disable 0162
            //Get all matching processes
            IEnumerable<Process> processes = Process.GetProcesses().Where(x => x.ProcessName.ToLower().StartsWith((string)Data.settings[0]));

            //processes = processes.Where(x => x.ProcessName.ToLower().Contains("program") || x.ProcessName.ToLower().Contains("") || x.ProcessName.ToLower().Contains(""));

            //Verify that the process isn't this program
            programProcess = processes.Where(x => !x.ProcessName.Equals(Process.GetCurrentProcess().ProcessName)).FirstOrDefault();

            //If there are no processes, return false
            if (programProcess == null) {
                return false;
            }

            //Process found, so get the main window handle from that process
            programHandle = programProcess.MainWindowHandle;

            //Get the name from the main window as well
            programName = programProcess.MainWindowTitle;

            //Update the program rectangle with the newly found window's info
            GetWindowSize();

            return true;
#pragma warning restore 0162
        }

        /// <summary>
        /// A way for other classes to tell the window to verify that the coordinates are correct
        /// </summary>
        public void UpdateWindowRect() {
            bool mouseIsDown = GetAsyncKeyState(VK_LBUTTON) < 0;
            if (!mouseIsDown) {
                GetWindowSize();
            }
        }

        /// <summary>
        /// Gets the window's rect and stores it
        /// </summary>
        private void GetWindowSize() {
            RECT rct;

            //Gets the width and height of the window
            GetClientRect(programHandle, out rct);

            programRect.Width = rct.Right;
            programRect.Height = rct.Bottom;

            //Gets the x and y of the window on the screen
            GetWindowRect(programHandle, ref rct);

            programRect.X = rct.Left + 9;
            programRect.Y = rct.Top + 2;

            if (programName != "" && (int)Data.settings[3] != 3) {
                bool validResize = true;
                foreach (Screen s in Screen.AllScreens) {
                    if (programRect.Width == s.Bounds.Width && programRect.Height == s.Bounds.Height) {
                        validResize = false;
                    }
                }

                if (validResize) {
                    ResizeWindow((int)Data.settings[3]);
                }
            }
        }

        /// <summary>
        /// Resizes the window to the requested aspect ratio
        /// </summary>
        /// <param name="ratio"></param>
        public void ResizeWindow(int ratio) {
            bool validResize = false;
            //Get the window's placement to tell if maximized or minimized
            WINDOWPLACEMENT placement = new WINDOWPLACEMENT();
            GetWindowPlacement(programHandle, ref placement);
            //If not minizimed or maximized
            validResize = placement.showCmd.Equals(1);

            if (validResize) {
                float idealWidth = 0;

                //4:3
                if (ratio == 0) {
                    idealWidth = programRect.Height * (4f / 3f);

                    if (idealWidth < 300) {
                        idealWidth = 300;
                        programRect.Height = (int)(idealWidth * (3f / 4f));

                        programRect.Y -= 2;
                        programRect.X -= 9;
                    }
                }

                //16:9
                if (ratio == 1) {
                    idealWidth = programRect.Height * (16f / 9f);

                    if (idealWidth < 300) {
                        idealWidth = 300;
                        programRect.Height = (int)(idealWidth * (9f / 16f));

                        programRect.Y -= 2;
                        programRect.X -= 9;
                    }
                }

                //1:1
                if (ratio == 2) {
                    idealWidth = programRect.Height * (1f / 1f);

                    if (idealWidth < 300) {
                        idealWidth = 300;
                        programRect.Height = 300;

                        programRect.Y -= 2;
                        programRect.X -= 9;
                    }
                }

                if (Math.Abs(idealWidth - programRect.Width) > 10) {
                    idealWidth += 4;
                    MoveWindow(programHandle, programRect.X, programRect.Y, (int)idealWidth, programRect.Height + 50, true);
                    programRect.Width = (int)idealWidth;
                }
            }
        }

        /// <summary>
        /// Clicks the mouse at the given percent point
        /// </summary>
        /// <param name="pointPercent">percent point to click at</param>
        public void ClickMouse(Info.PercentPoint pointPercent) {
            Point absolute = RelativeToAbsolute(pointPercent.X, pointPercent.Y);

            MouseOperations.LeftMouseClick(programHandle, absolute);
        }

        /// <summary>
        /// Moves the mouse to the given x and y percent
        /// </summary>
        /// <param name="xPercent">x percent to move mouse to, 0-100</param>
        /// <param name="yPercent">y percent to move mouse to, 0-100</param>
        public void MoveMouse(float xPercent, float yPercent) {
            Point absolute = RelativeToAbsolute(xPercent, yPercent);

            MouseOperations.SetCursorPosition(programHandle, absolute);
        }

        /// <summary>
        /// Moves the mouse to the given percent point
        /// </summary>
        /// <param name="pointPercent">percent point to move mouse to</param>
        public void MoveMouse(Info.PercentPoint pointPercent) {
            Point absolute = RelativeToAbsolute(pointPercent.X, pointPercent.Y);

            MouseOperations.SetCursorPosition(programHandle, absolute);
        }

        /// <summary>
        /// Converts a percent point to an absolute point
        /// </summary>
        /// <param name="percentPoint">percent point to convert to absolute</param>
        /// <returns></returns>
        public Point RelativeToAbsolute(Info.PercentPoint percentPoint) {
            return RelativeToAbsolute(percentPoint.X, percentPoint.Y);
        }

        /// <summary>
        /// Converts a relative point to an absolute point
        /// </summary>
        /// <param name="x">x point to convert to absolute</param>
        /// <param name="y">y point to convert to absolute</param>
        /// <returns></returns>
        public Point RelativeToAbsolute(float x, float y) {
            //Convert the x and y to percents
            float percentX = x / 100f;
            float percentY = y / 100f;

            //Get the starting x and y
            float startingX = programRect.X;
            float startingY = programRect.Y + 50;

            //Get the starting width and height
            float width = programRect.Width;
            float height = programRect.Height;

            //Convert the percents to real x and y values
            int totalX = (int)(startingX + (width * percentX));
            int totalY = (int)(startingY + (height * percentY));

            return new Point(totalX, totalY);
        }

        /// <summary>
        /// Returns the X coordinate of the window
        /// </summary>
        /// <returns></returns>
        public int GetX() {
            return programRect.X;
        }

        /// <summary>
        /// Returns the Y coordinate of the window
        /// </summary>
        /// <returns></returns>
        public int GetY() {
            return programRect.Y;
        }

        /// <summary>
        /// Returns the Width of the window
        /// </summary>
        /// <returns></returns>
        public int GetWidth() {
            return programRect.Width;
        }

        /// <summary>
        /// Returns the Height of the window
        /// </summary>
        /// <returns></returns>
        public int GetHeight() {
            return programRect.Height;
        }

        /// <summary>
        /// Returns the name of the window
        /// </summary>
        /// <returns></returns>
        public string GetWindowName() {
            return programName;
        }

        public const int VK_LBUTTON = 0x01;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

        [DllImport("user32.dll")]
        private static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref RECT rectangle);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        private struct WINDOWPLACEMENT {
            public int length;
            public int flags;
            public int showCmd;
            public Point ptMinPosition;
            public Point ptMaxPosition;
            public Rectangle rcNormalPosition;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }
    }
}