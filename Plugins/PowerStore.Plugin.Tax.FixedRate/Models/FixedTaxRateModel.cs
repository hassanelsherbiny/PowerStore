using PowerStore.Core.ModelBinding;

namespace PowerStore.Plugin.Tax.FixedRate.Models
{
    public class FixedTaxRateModel
    {
        public string TaxCategoryId { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Tax.FixedRate.Fields.TaxCategoryName")]
        public string TaxCategoryName { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Tax.FixedRate.Fields.Rate")]
        public decimal Rate { get; set; }
    }
}