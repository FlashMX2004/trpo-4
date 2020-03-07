using System;
using System.IO;
using System.Text;

namespace DesignPatternsConsole
{
    /// <summary>
    /// Manager to work with file data
    /// </summary>
    public static class FileManager
    {
        /// <summary>
        /// Reads os from file with path
        /// </summary>
        /// <param name="path">Path of the file</param>
        /// <returns>String from file</returns>
        public static OS ReadOSFromFile(string path)
        {
            using var reader = new StreamReader(path, Encoding.Default);
            return (OS)Enum.Parse(typeof(OS), reader.ReadLine());
        }
        /// <summary>
        /// Saves configuration into file
        /// </summary>
        /// <param name="path">Path to file or file name</param>
        /// <param name="configuration">Configuration to save</param>
        public static void WriteConfigurationToFile(string path, AbstractConfiguration configuration)
        {
            using StreamWriter writer = new StreamWriter(path, false, Encoding.Default);
            foreach (var item in configuration)
            {
                writer.WriteLine(string.Format("{0}: {1}", item.Key, item.Value));
            }
        }
    }
}
