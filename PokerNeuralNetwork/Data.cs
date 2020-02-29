using System.Collections.Generic;
using System.Drawing;

namespace PokerNeuralNetwork {

    /// <summary>
    /// Data that's often changed by the code, easy way to access everything
    /// </summary>
    public static class Data {

        /// <summary>
        /// Settings
        /// 0 - Process Name
        /// 1 - Process Search Delay
        /// 2 - Update Delay
        /// </summary>
        public static object[] settings = new object[3];

        /// <summary>
        /// Images that are used throughout the project
        /// </summary>
        public static Bitmap[] images = new Bitmap[2];

        /// <summary>
        /// Keep track of the previous command
        /// </summary>
        public static List<string> previousCommands = new List<string>();

        /// <summary>
        /// Window of Hooked Program
        /// </summary>
        public static HookedWindow window = null;

        /// <summary>
        /// A reference to the main form
        /// </summary>
        public static MainForm form = null;

        /// <summary>
        /// List of all the poker games
        /// </summary>
        public static List<Poker.Holdem> games = new List<Poker.Holdem>(0);
        
    }
}