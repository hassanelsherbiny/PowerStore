using PowerStore.Domain.Configuration;

namespace PowerStore.Plugin.ExternalAuth.Google
{
    public class GoogleExternalAuthSettings : ISettings
    {
        public string ClientKeyIdentifier { get; set; }
        public string ClientSecret { get; set; }
    }
}
