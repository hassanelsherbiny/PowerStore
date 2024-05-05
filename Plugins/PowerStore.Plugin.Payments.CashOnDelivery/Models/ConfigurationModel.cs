using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using PowerStore.Framework.Localization;
using System.Collections.Generic;

namespace PowerStore.Plugin.Payments.CashOnDelivery.Models
{
    public class ConfigurationModel : BaseModel, ILocalizedModel<ConfigurationModel.ConfigurationLocalizedModel>
    {
        public ConfigurationModel()
        {
            Locales = new List<ConfigurationLocalizedModel>();
        }

        public string ActiveStoreScopeConfiguration { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Payment.CashOnDelivery.DescriptionText")]
        public string DescriptionText { get; set; }
        public bool DescriptionText_OverrideForStore { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Payment.CashOnDelivery.AdditionalFee")]
        public decimal AdditionalFee { get; set; }
        public bool AdditionalFee_OverrideForStore { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Payment.CashOnDelivery.AdditionalFeePercentage")]
        public bool AdditionalFeePercentage { get; set; }
        public bool AdditionalFeePercentage_OverrideForStore { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Payment.CashOnDelivery.ShippableProductRequired")]
        public bool ShippableProductRequired { get; set; }
        public bool ShippableProductRequired_OverrideForStore { get; set; }

        public IList<ConfigurationLocalizedModel> Locales { get; set; }

        #region Nested class

        public partial class ConfigurationLocalizedModel : ILocalizedModelLocal
        {
            public string LanguageId { get; set; }

            [PowerStoreResourceDisplayName("Plugins.Payment.CashOnDelivery.DescriptionText")]
            public string DescriptionText { get; set; }
        }

        #endregion
    }
}