using System.Collections.Generic;

namespace DesignPatternsConsole
{
    /// <summary>
    /// Abstract configuration, implementing property container pattern
    /// </summary>
    public abstract class AbstractConfiguration
    {
        /// <summary>
        /// Minimal capacity in container
        /// </summary>
        public const int MIN_CAPACITY = 10;
        /// <summary>
        /// Names of parameters in configuration
        /// </summary>
        public readonly string[] parameterNames = new string[]
        {
            "First parameter",
            "Second parameter",
            "Third parameter",
            "4th parameter",
            "5th parameter",
            "6th parameter",
            "7th parameter",
            "8th parameter",
            "9th parameter",
            "10th parameter",
        };
        /// <summary>
        /// Returns configuration parameter by name
        /// </summary>
        /// <param name="name">Name of parameter</param>
        /// <returns>Configuration parameter</returns>
        public abstract string GetParameter(string name);
        /// <summary>
        /// Sets configuration parameter
        /// </summary>
        /// <param name="name">Name of parameter</param>
        /// <param name="parameter">Configuration parameter</param>
        public abstract void SetParameter(string name, string parameter);
        /// <summary>
        /// Returns parameters enumerator
        /// </summary>
        /// <returns>Enumerator</returns>
        public abstract IEnumerator<KeyValuePair<string, string>> GetEnumerator();
    }
}
