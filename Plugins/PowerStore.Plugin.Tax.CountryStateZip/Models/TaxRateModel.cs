using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Plugin.Tax.CountryStateZip.Models
{
    public class TaxRateModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Store")]
        public string StoreId { get; set; }
        [PowerStoreResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Store")]
        public string StoreName { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.TaxCategory")]
        public string TaxCategoryId { get; set; }
        [PowerStoreResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.TaxCategory")]
        public string TaxCategoryName { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Country")]
        public string CountryId { get; set; }
        [PowerStoreResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Country")]
        public string CountryName { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.StateProvince")]
        public string StateProvinceId { get; set; }
        [PowerStoreResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.StateProvince")]
        public string StateProvinceName { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Zip")]
        public string Zip { get; set; }

        [PowerStoreResourceDisplayName("Plugins.Tax.CountryStateZip.Fields.Percentage")]
        public decimal Percentage { get; set; }
    }
}