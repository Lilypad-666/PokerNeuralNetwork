using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;
using System.Collections.Generic;

namespace PokerNeuralNetwork {

    /// <summary>
    /// Console class to take care of debugging and logging
    /// </summary>
    public static class Console {

        //Different log types
        public enum LogTypes {
            DEBUG,
            INFO,
            CMD,
            WARN,
            ERROR,
            FATAL
        }

        /// <summary>
        /// Keep track of the previous command
        /// </summary>
        public static List<string> previousCommands = new List<string>();

        /// <summary>
        /// Current console command, lets you use previous commands
        /// </summary>
        public static int currentCommand = -1;

        /// <summary>
        /// Log data that hasn't been written yet
        /// </summary>
        private static string notWritten = "";

        /// <summary>
        /// Locker to keep threads from writing over each other
        /// </summary>
        private static ReaderWriterLock locker = new ReaderWriterLock();

        /// <summary>
        /// Catches all non-ui errors and writes them to the log as a fatal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void UnhandledException(object sender, UnhandledExceptionEventArgs e) {
            Exception exception = e.ExceptionObject as Exception;
            WriteLine(exception.Message + Environment.NewLine + exception.StackTrace, LogTypes.FATAL);
        }

        /// <summary>
        /// Catches all ui errors and writes them to the log as a fatal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void ThreadException(object sender, ThreadExceptionEventArgs e) {
            Exception exception = e.Exception;
            WriteLine(exception.Message + Environment.NewLine + exception.StackTrace, LogTypes.FATAL);
        }

        /// <summary>
        /// Sends a command to the console
        /// </summary>
        /// <param name="text"></param>
        public static void SendCommand(string text) {
            //Write the command to the log
            WriteLine(text, LogTypes.CMD);

            string[] tokens = text.Split(' ');

            //Sorts by how many tokens
            if (tokens.Length == 1) {
                //Hooks the keyboard
                if (text.ToUpper().Equals("PING")) {
                    WriteLine("PONG!");
                }
            }
        }

        /// <summary>
        /// Writes a line to the console and the log from an object's ToString()
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="type"></param>
        public static void WriteLine(object obj, LogTypes type = LogTypes.INFO) {
            if (obj != null) {
                WriteLine(obj.ToString(), type);
            } else {
                WriteLine("Null passed in to console!", LogTypes.ERROR);
            }
        }

        /// <summary>
        /// Writes a line to the console and the log from a string
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
        public static void WriteLine(string text, LogTypes type = LogTypes.INFO) {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) {
                return;
            }

            //Get the stack trace
            StackTrace stackTrace = new StackTrace(true);

            string thisFileName = stackTrace.GetFrame(0).GetFileName();
            StackFrame stackFrame = null;

            int frame = 1;
            //Get the first stack frame that isn't from this file
            while (stackFrame == null || stackFrame.GetFileName() == thisFileName) {
                stackFrame = stackTrace.GetFrame(frame++);
            }

            //Get data from the function that called this
            int lineNum = stackFrame.GetFileLineNumber();
            string fileName = Path.GetFileName(stackFrame.GetFileName());
            string methodName = stackFrame.GetMethod().Name;

            //Get the date and time
            DateTime now = DateTime.Now;
            string date = now.ToString("yyyy-MM-dd");
            string time = now.ToString("HH:mm:ss");

            //Get the type of log this is
            string typeText = type.ToString();

            //Create the output with formatting
            string output = "";

            output += time + " | ";
            output += typeText + " | ";
            output += fileName + ":" + methodName + "():" + lineNum + " | ";

            output += text + Environment.NewLine;

            if (MainForm.Debug) {
                System.Console.Write(output);
            }

            //Append the text to the console
            MainForm.ConsoleMessage(output, LogTypeToColor(type));

            //If we're not in debug mode
            if (!MainForm.Debug) {

                //If a log file for today doesn't exist
                if (!File.Exists("Logs/" + date + ".log")) {
                    //Make one and write the output to it
                    StreamWriter sw = File.CreateText("Logs/" + date + ".log");
                    sw.Write(output);
                    sw.Close();
                } else {
                    try {
                        notWritten += output;

                        if (!locker.IsWriterLockHeld) {
                            locker.AcquireWriterLock(-1);

                            if (locker.IsWriterLockHeld) {
                                File.AppendAllText("Logs/" + date + ".log", output);

                                notWritten = "";
                            }
                        }

                    } catch {
                        notWritten += output;
                    } finally {
                        locker.ReleaseWriterLock();
                    }
                }

                //If the log is an error
                if (type == LogTypes.ERROR) {
                    string caption = "Error!";

                    string message = text + Environment.NewLine + "The program may not function as intended." + Environment.NewLine + "Do you wish to exit?";

                    //Show a message box asking the user if they want to exit the program
                    DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

                    //If they don't click no, exit the program
                    if (result != DialogResult.No) {
                        WriteLine("User has exited after error.");
                        Environment.Exit(1);
                    }
                }

                //If the log is a fatal
                if (type == LogTypes.FATAL) {
                    string error = text.Substring(0, text.IndexOf("\n"));
                    string caption = "Fatal Error!";

                    string message = error + Environment.NewLine + "Check the Logs folder for more info, please report this." + Environment.NewLine + "The program will now exit.";

                    //Show a message box telling the user that the program is closing
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    Environment.Exit(2);
                }
            }
        }

        /// <summary>
        /// Gets the color for the given log type
        /// </summary>
        /// <param name="type">Type of log entry</param>
        /// <returns>Color of text to output</returns>
        private static Color LogTypeToColor(LogTypes type) {
            switch (type) {
                case LogTypes.DEBUG:
                    return Color.White;

                case LogTypes.CMD:
                    return Color.Aqua;

                case LogTypes.WARN:
                    return Color.Yellow;

                case LogTypes.ERROR:
                    return Color.Orange;

                case LogTypes.FATAL:
                    return Color.Red;

                default:
                    return Color.Lime;
            }
        }
    }
}