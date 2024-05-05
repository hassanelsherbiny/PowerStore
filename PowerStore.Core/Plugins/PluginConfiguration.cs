using System.Collections.Generic;

namespace PowerStore.Core.Plugins
{
    public class PluginConfiguration
    {
        public PluginConfiguration()
        {
            LimitedToStore = new List<string>();
        }
        public string FriendlyName { get; set; }
        public IList<string> LimitedToStore { get; set; }
        public int DisplayOrder { get; set; }
    }
}
