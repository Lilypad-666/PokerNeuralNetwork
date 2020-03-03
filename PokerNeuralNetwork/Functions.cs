using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PokerNeuralNetwork {
    public static class Functions {

        /// <summary>
        /// Saves the given data to the file as binary
        /// </summary>
        /// <typeparam name="T">Type of object to write</typeparam>
        /// <param name="filePath">Name of the file to save to</param>
        /// <param name="objectToWrite">Object to write</param>
        public static void Save<T>(string filePath, T objectToWrite) {
            using (Stream stream = File.Open("Data/" + filePath, FileMode.Create)) {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
            Console.WriteLine("Saved to Data/" + filePath);
        }

        /// <summary>
        /// Reads the data from the file back to type T
        /// </summary>
        /// <typeparam name="T">Type of object to read to</typeparam>
        /// <param name="filePath">Name of the file to read from</param>
        /// <returns></returns>
        public static T Load<T>(string filePath) {
            using (Stream stream = File.Open("Data/" + filePath, FileMode.Open)) {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                Console.WriteLine("Loaded from Data/" + filePath);
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
