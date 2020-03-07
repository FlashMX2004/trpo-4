using DesignPatternsConsole.Configurations;

namespace DesignPatternsConsole.ConfigurationFactories
{
    /// <summary>
    /// Factory for creating program configuration parameters for Windows
    /// </summary>
    public class WindowsConfigurationFactory : AbstractConfigurationFactory
    {
        /// <summary>
        /// Creates and returns program configuration parameters for Windows
        /// </summary>
        /// <returns>Configuration parameters for Windows</returns>
        public override AbstractConfiguration CreateConfiguration() => new WindowsConfiguration();
    }
}
