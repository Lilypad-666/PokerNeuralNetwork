using System;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace PokerNeuralNetwork {

    internal static class Program {

        [STAThread]
        private static void Main(string[] args) {

            //If debugging
            if (args.Length > 0 && args[0].Equals("1")) {
                Info.debug = true;

                //Show the console window
                ShowConsoleWindow();
            } else {
                Info.debug = false;

                //UI Excepitons
                Application.ThreadException += new ThreadExceptionEventHandler(Console.ThreadException);

                //Force exceptions to go through our handler
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

                //Non-UI Exceptions
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(Console.UnhandledException);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm());
        }

        /// <summary>
        /// Shows the console window for debug
        /// </summary>
        public static void ShowConsoleWindow() {
            var handle = GetConsoleWindow();

            if (handle == IntPtr.Zero) {
                AllocConsole();
            } else {
                ShowWindow(handle, SW_SHOW);
            }
        }

        /// <summary>
        /// Hides the console window
        /// </summary>
        public static void HideConsoleWindow() {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
    }
}