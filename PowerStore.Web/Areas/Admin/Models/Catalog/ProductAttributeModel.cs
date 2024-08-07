﻿using PowerStore.Framework.Localization;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.Collections.Generic;
using PowerStore.Framework.Mapping;
using PowerStore.Framework.Mvc.Models;

namespace PowerStore.Web.Areas.Admin.Models.Catalog
{
    public partial class ProductAttributeModel : BaseEntityModel, ILocalizedModel<ProductAttributeLocalizedModel>, IStoreMappingModel
    {
        public ProductAttributeModel()
        {
            Locales = new List<ProductAttributeLocalizedModel>();
        }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.Fields.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.Fields.SeName")]
        public string SeName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.Fields.Description")]
        public string Description { get; set; }

        //Store mapping
        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }
        public string[] SelectedStoreIds { get; set; }

        public IList<ProductAttributeLocalizedModel> Locales { get; set; }

        #region Nested classes

        public partial class UsedByProductModel : BaseEntityModel
        {
            [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.UsedByProducts.Product")]
            public string ProductName { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.UsedByProducts.Published")]
            public bool Published { get; set; }
        }

        #endregion
    }

    public partial class ProductAttributeLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.Fields.Description")]

        public string Description { get; set; }
    }

    public partial class PredefinedProductAttributeValueModel : BaseEntityModel, ILocalizedModel<PredefinedProductAttributeValueLocalizedModel>
    {
        public PredefinedProductAttributeValueModel()
        {
            Locales = new List<PredefinedProductAttributeValueLocalizedModel>();
        }

        public string ProductAttributeId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.PriceAdjustment")]
        public decimal PriceAdjustment { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.PriceAdjustment")]
        //used only on the values list page
        public string PriceAdjustmentStr { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.WeightAdjustment")]
        public decimal WeightAdjustment { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.WeightAdjustment")]
        //used only on the values list page
        public string WeightAdjustmentStr { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.Cost")]
        public decimal Cost { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.IsPreSelected")]
        public bool IsPreSelected { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<PredefinedProductAttributeValueLocalizedModel> Locales { get; set; }
    }
    public partial class PredefinedProductAttributeValueLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.Name")]

        public string Name { get; set; }
    }
}