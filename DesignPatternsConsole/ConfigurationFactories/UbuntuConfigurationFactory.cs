using DesignPatternsConsole.Configurations;

namespace DesignPatternsConsole.ConfigurationFactories
{
    /// <summary>
    /// Factory for creating program configuration parameters for Ubuntu
    /// </summary>
    public class UbuntuConfigurationFactory : AbstractConfigurationFactory
    {
        /// <summary>
        /// Creates and returns program configuration parameters for Ubuntu
        /// </summary>
        /// <returns>Configuration parameters for Ubuntu</returns>
        public override AbstractConfiguration CreateConfiguration() => new UbuntuConfiguration();
    }
}
