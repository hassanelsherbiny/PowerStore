using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Plugin.Widgets.GoogleAnalytics.Models
{
    public class ConfigurationModel : BaseModel
    {
        public string ActiveStoreScopeConfiguration { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.GoogleAnalytics.GoogleId")]
        public string GoogleId { get; set; }
        public bool GoogleId_OverrideForStore { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.GoogleAnalytics.TrackingScript")]
        //tracking code
        public string TrackingScript { get; set; }
        public bool TrackingScript_OverrideForStore { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.GoogleAnalytics.EcommerceScript")]
        public string EcommerceScript { get; set; }
        public bool EcommerceScript_OverrideForStore { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.GoogleAnalytics.EcommerceDetailScript")]
        public string EcommerceDetailScript { get; set; }
        public bool EcommerceDetailScript_OverrideForStore { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.GoogleAnalytics.IncludingTax")]
        public bool IncludingTax { get; set; }
        public bool IncludingTax_OverrideForStore { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.GoogleAnalytics.AllowToDisableConsentCookie")]
        public bool AllowToDisableConsentCookie { get; set; }
        public bool AllowToDisableConsentCookie_OverrideForStore { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.GoogleAnalytics.ConsentDefaultState")]
        public bool ConsentDefaultState { get; set; }
        public bool ConsentDefaultState_OverrideForStore { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.GoogleAnalytics.ConsentName")]
        public string ConsentName { get; set; }
        public bool ConsentName_OverrideForStore { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Widgets.GoogleAnalytics.ConsentDescription")]
        public string ConsentDescription { get; set; }
        public bool ConsentDescription_OverrideForStore { get; set; }

    }
}