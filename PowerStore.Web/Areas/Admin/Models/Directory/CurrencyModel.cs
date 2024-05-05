using PowerStore.Framework.Localization;
using PowerStore.Framework.Mapping;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PowerStore.Framework.Mvc.Models;

namespace PowerStore.Web.Areas.Admin.Models.Directory
{
    public partial class CurrencyModel : BaseEntityModel, ILocalizedModel<CurrencyLocalizedModel>, IStoreMappingModel
    {
        public CurrencyModel()
        {
            Locales = new List<CurrencyLocalizedModel>();
            AvailableStores = new List<StoreModel>();
        }
        [PowerStoreResourceDisplayName("Admin.Configuration.Currencies.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Currencies.Fields.CurrencyCode")]

        public string CurrencyCode { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Currencies.Fields.DisplayLocale")]

        public string DisplayLocale { get; set; }

        [UIHint("DecimalN4")]
        [PowerStoreResourceDisplayName("Admin.Configuration.Currencies.Fields.Rate")]
        public decimal Rate { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Currencies.Fields.CustomFormatting")]
        public string CustomFormatting { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Currencies.Fields.NumberDecimal")]
        public int NumberDecimal { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Currencies.Fields.Published")]
        public bool Published { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Currencies.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Currencies.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Currencies.Fields.IsPrimaryExchangeRateCurrency")]
        public bool IsPrimaryExchangeRateCurrency { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Currencies.Fields.IsPrimaryStoreCurrency")]
        public bool IsPrimaryStoreCurrency { get; set; }

        public IList<CurrencyLocalizedModel> Locales { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Currencies.Fields.RoundingType")]
        public int RoundingTypeId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Currencies.Fields.MidpointRound")]
        public int MidpointRoundId { get; set; }

        //Store mapping
        [PowerStoreResourceDisplayName("Admin.Configuration.Currencies.Fields.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        [PowerStoreResourceDisplayName("Admin.Configuration.Currencies.Fields.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }
        public string[] SelectedStoreIds { get; set; }
    }

    public partial class CurrencyLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Currencies.Fields.Name")]

        public string Name { get; set; }
    }
}