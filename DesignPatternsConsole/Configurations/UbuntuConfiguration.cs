using System.Collections.Generic;

namespace DesignPatternsConsole.Configurations
{
    public class UbuntuConfiguration : AbstractConfiguration
    {
        private const string PREFIX = "Ubuntu ";
        /// <summary>
        /// Container
        /// </summary>
        private readonly Dictionary<string, string> container = new Dictionary<string, string>(MIN_CAPACITY);

        public UbuntuConfiguration()
        {
            foreach (var name in this.parameterNames)
            {
                this.SetParameter(name, PREFIX + name);
            }
        }

        /// <summary>
        /// Returns Ubuntu configuration parameter by name
        /// </summary>
        /// <param name="name">Name of parameter</param>
        /// <returns>Configuration parameter</returns>
        public override string GetParameter(string name) => container.ContainsKey(name) ? container[name] : null;
        /// <summary>
        /// Sets Ubuntu configuration parameter
        /// </summary>
        /// <param name="name">Name of parameter</param>
        /// <param name="parameter">Configuration parameter</param>
        public override void SetParameter(string name, string parameter) => container[name] = parameter;
        /// <summary>
        /// Returns parameters enumerator
        /// </summary>
        /// <returns>Enumerator</returns>
        public override IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            foreach (KeyValuePair<string, string> item in container)
            {
                yield return item;
            }
        }
    }
}
