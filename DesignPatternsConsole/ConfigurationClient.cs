namespace DesignPatternsConsole
{
    /// <summary>
    /// Client returns configuration by configuration factory
    /// </summary>
    public class ConfigurationClient
    {
        /// <summary>
        /// Configuration field
        /// </summary>
        private readonly AbstractConfiguration configuration;

        public ConfigurationClient(AbstractConfigurationFactory factory)
        {
            this.configuration = factory.CreateConfiguration();
        }

        /// <summary>
        /// Returns configuration parameters of program
        /// </summary>
        /// <returns>Configuration</returns>
        public AbstractConfiguration GetConfiguration() => this.configuration;
    }
}
