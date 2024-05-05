using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Plugin.ExternalAuth.Google.Models
{
    public class ConfigurationModel : BaseModel
    {
        public string ActiveStoreScopeConfiguration { get; set; }

        [PowerStoreResourceDisplayName("Plugins.ExternalAuth.Google.ClientKeyIdentifier")]
        public string ClientKeyIdentifier { get; set; }
        public bool ClientKeyIdentifier_OverrideForStore { get; set; }

        [PowerStoreResourceDisplayName("Plugins.ExternalAuth.Google.ClientSecret")]
        public string ClientSecret { get; set; }
        public bool ClientSecret_OverrideForStore { get; set; }
    }
}
