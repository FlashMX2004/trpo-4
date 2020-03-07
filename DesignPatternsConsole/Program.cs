using System;
using DesignPatternsConsole.ConfigurationFactories;

namespace DesignPatternsConsole
{
    internal class Program
    {
        /// <summary>
        /// Name of file to read sources
        /// </summary>
        private const string READ_FILE_NAME = "input.txt";
        /// <summary>
        /// Name of file to write sources
        /// </summary>
        private const string WRITE_FILE_NAME = "output.txt";

        private static void Main()
        {
            OS os = FileManager.ReadOSFromFile(READ_FILE_NAME);

            ConfigurationClient client = os switch
            {
                OS.Windows => new ConfigurationClient(new WindowsConfigurationFactory()),
                OS.Mac => new ConfigurationClient(new MacConfigurationFactory()),
                OS.Ubuntu => new ConfigurationClient(new UbuntuConfigurationFactory()),
                _ => null
            };
            var configuration = client.GetConfiguration();

            FileManager.WriteConfigurationToFile(WRITE_FILE_NAME, configuration);
        }
    }
}
