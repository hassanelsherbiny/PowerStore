using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Plugin.ExternalAuth.Facebook.Models
{
    public class ConfigurationModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Plugins.ExternalAuth.Facebook.ClientKeyIdentifier")]
        public string ClientId { get; set; }

        [PowerStoreResourceDisplayName("Plugins.ExternalAuth.Facebook.ClientSecret")]
        public string ClientSecret { get; set; }
    }
}