using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PokerNeuralNetwork {
    class SaveData {
        public static string FileName = "Data.dat";

        public bool ConsolePopOut { get; set; } = false;
        public int SmallBlind { get; set; } = 10;
        public int StartingChips { get; set; } = 1500;
        public int Players { get; set; } = 6;
    }

    static class Data {
        /// <summary>
        /// Locker to keep threads from writing over each other
        /// </summary>
        private static ReaderWriterLock locker = new ReaderWriterLock();

        public static void Save(SaveData data) {
            Console.WriteLine("WRITING: " + JsonConvert.SerializeObject(data));
            try {
                if (!locker.IsWriterLockHeld) {
                    locker.AcquireWriterLock(30_000);

                    if (locker.IsWriterLockHeld) {
                        File.WriteAllText("Data/" + SaveData.FileName, JsonConvert.SerializeObject(data));
                    }
                }
            } finally {
                locker.ReleaseWriterLock();
            }
        }

        public static SaveData Load() {
            if (File.Exists("Data/" + SaveData.FileName)) {
                string json = File.ReadAllText("Data/" + SaveData.FileName);
                return JsonConvert.DeserializeObject<SaveData>(json);
            }

            return null;
        }
    }
}
