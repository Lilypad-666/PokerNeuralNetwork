using System;

namespace PokerNeuralNetwork {

    /// <summary>
    /// Static info to keep track of
    /// </summary>
    public class Info {

        /// <summary>
        /// Whether we're in debug mode or not
        /// </summary>
        public static bool debug;

        /// <summary>
        /// Bool to keep track of finding game
        /// </summary>
        public static bool foundGame = false;

        /// <summary>
        /// Whether we're toggling tabs
        /// </summary>
        public static bool toggleTabs = false;

        /// <summary>
        /// Bool to keep track of active window
        /// </summary>
        public static bool isFocusedWindow = false;

        /// <summary>
        /// Version of the program
        /// </summary>
        public static string version;

        /// <summary>
        /// Delay for the search timer
        /// </summary>
        public static int searchDelay = 2000;

        /// <summary>
        /// Delay for the update timer
        /// </summary>
        public static int updateDelay = 250;

        /// <summary>
        /// The current delay for the timer
        /// </summary>
        public static int currentDelay = 2000;

        /// <summary>
        /// A struct to handle points in percent, 0-100
        /// </summary>
        public struct PercentPoint {
            public float X;
            public float Y;

            /// <summary>
            /// Create a percent point
            /// </summary>
            /// <param name="x">Percet of x, 0-100</param>
            /// <param name="y">Percent of y, 0-100</param>
            public PercentPoint(float x, float y) {
                X = x;
                Y = y;

                if (X < 0) {
                    X = 0;
                }

                if (X > 100) {
                    X = 100;
                }

                if (Y < 0) {
                    Y = 0;
                }

                if (Y > 100) {
                    Y = 100;
                }
            }
        }
    }
}