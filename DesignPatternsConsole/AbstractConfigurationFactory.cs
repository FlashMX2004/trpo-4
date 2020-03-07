namespace DesignPatternsConsole
{
    /// <summary>
    /// Abstract configuration factory, implementing abstract factory pattern
    /// </summary>
    public abstract class AbstractConfigurationFactory
    {
        /// <summary>
        /// Abstract factory method for creating configuration product
        /// </summary>
        /// <returns>Configuration</returns>
        public abstract AbstractConfiguration CreateConfiguration();
    }
}