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
                MainForm.debug = true;

                //Show the console window
                ShowConsoleWindow();
            } else {
                MainForm.debug = false;

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
        private static void ShowConsoleWindow() {
            var handle = GetConsoleWindow();

            if (handle == IntPtr.Zero) {
                AllocConsole();
            } else {
                ShowWindow(handle, SW_SHOW);
            }
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 5;
    }
}