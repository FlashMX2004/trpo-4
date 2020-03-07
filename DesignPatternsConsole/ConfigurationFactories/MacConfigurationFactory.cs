using DesignPatternsConsole.Configurations;

namespace DesignPatternsConsole.ConfigurationFactories
{
    /// <summary>
    /// Factory for creating program configuration parameters for Mac OS
    /// </summary>
    public class MacConfigurationFactory : AbstractConfigurationFactory
    {
        /// <summary>
        /// Creates and returns program configuration parameters for Mac OS
        /// </summary>
        /// <returns>Configuration parameters for Mac OS</returns>
        public override AbstractConfiguration CreateConfiguration() => new MacConfiguration();
    }
}
