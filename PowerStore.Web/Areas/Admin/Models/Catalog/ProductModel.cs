using PowerStore.Framework.Localization;
using PowerStore.Framework.Mapping;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using PowerStore.Web.Areas.Admin.Models.Discounts;
using PowerStore.Web.Areas.Admin.Validators.Catalog;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PowerStore.Framework.Mvc.Models;

namespace PowerStore.Web.Areas.Admin.Models.Catalog
{
    public partial class ProductModel : BaseEntityModel, ILocalizedModel<ProductLocalizedModel>, IAclMappingModel, IStoreMappingModel
    {
        public ProductModel()
        {
            Locales = new List<ProductLocalizedModel>();
            ProductPictureModels = new List<ProductPictureModel>();
            CopyProductModel = new CopyProductModel();
            AvailableBasepriceUnits = new List<SelectListItem>();
            AvailableBasepriceBaseUnits = new List<SelectListItem>();
            AvailableProductTemplates = new List<SelectListItem>();
            AvailableVendors = new List<SelectListItem>();
            AvailableTaxCategories = new List<SelectListItem>();
            AvailableDeliveryDates = new List<SelectListItem>();
            AvailableWarehouses = new List<SelectListItem>();
            AvailableCategories = new List<SelectListItem>();
            AvailableManufacturers = new List<SelectListItem>();
            AvailableProductAttributes = new List<SelectListItem>();
            AvailableUnits = new List<SelectListItem>();
            AddPictureModel = new ProductPictureModel();
            AvailableStores = new List<StoreModel>();
            AvailableCustomerRoles = new List<CustomerRoleModel>();
            AddSpecificationAttributeModel = new AddProductSpecificationAttributeModel();
            ProductWarehouseInventoryModels = new List<ProductWarehouseInventoryModel>();
            CalendarModel = new GenerateCalendarModel();
        }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.ID")]
        public override string Id { get; set; }

        //picture thumbnail
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.PictureThumbnailUrl")]
        public string PictureThumbnailUrl { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.ProductType")]
        public int ProductTypeId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.ProductType")]
        public string ProductTypeName { get; set; }
        public bool AuctionEnded { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.AssociatedToProductName")]
        public string AssociatedToProductId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.AssociatedToProductName")]
        public string AssociatedToProductName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.VisibleIndividually")]
        public bool VisibleIndividually { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.ProductTemplate")]
        public string ProductTemplateId { get; set; }
        public IList<SelectListItem> AvailableProductTemplates { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.ShortDescription")]
        public string ShortDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.FullDescription")]
        public string FullDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Flag")]
        public string Flag { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.AdminComment")]
        public string AdminComment { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Vendor")]
        public string VendorId { get; set; }
        public IList<SelectListItem> AvailableVendors { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.ShowOnHomePage")]
        public bool ShowOnHomePage { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.MetaKeywords")]

        public string MetaKeywords { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.MetaDescription")]

        public string MetaDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.MetaTitle")]

        public string MetaTitle { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.SeName")]

        public string SeName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.AllowCustomerReviews")]
        public bool AllowCustomerReviews { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.ProductTags")]
        public string ProductTags { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Sku")]

        public string Sku { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.ManufacturerPartNumber")]

        public string ManufacturerPartNumber { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.GTIN")]

        public virtual string Gtin { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.IsGiftCard")]
        public bool IsGiftCard { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.GiftCardType")]
        public int GiftCardTypeId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.OverriddenGiftCardAmount")]
        [UIHint("DecimalNullable")]
        public decimal? OverriddenGiftCardAmount { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.RequireOtherProducts")]
        public bool RequireOtherProducts { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.RequiredProductIds")]
        public string RequiredProductIds { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.AutomaticallyAddRequiredProducts")]
        public bool AutomaticallyAddRequiredProducts { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.IsDownload")]
        public bool IsDownload { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Download")]
        [UIHint("Download")]
        public string DownloadId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.UnlimitedDownloads")]
        public bool UnlimitedDownloads { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.MaxNumberOfDownloads")]
        public int MaxNumberOfDownloads { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.DownloadExpirationDays")]
        [UIHint("Int32Nullable")]
        public int? DownloadExpirationDays { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.DownloadActivationType")]
        public int DownloadActivationTypeId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.HasSampleDownload")]
        public bool HasSampleDownload { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.SampleDownload")]
        [UIHint("Download")]
        public string SampleDownloadId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.HasUserAgreement")]
        public bool HasUserAgreement { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.UserAgreementText")]

        public string UserAgreementText { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.IsRecurring")]
        public bool IsRecurring { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.RecurringCycleLength")]
        public int RecurringCycleLength { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.RecurringCyclePeriod")]
        public int RecurringCyclePeriodId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.RecurringTotalCycles")]
        public int RecurringTotalCycles { get; set; }

        //calendar
        public GenerateCalendarModel CalendarModel { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.IsShipEnabled")]
        public bool IsShipEnabled { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.IsFreeShipping")]
        public bool IsFreeShipping { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.ShipSeparately")]
        public bool ShipSeparately { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.AdditionalShippingCharge")]
        public decimal AdditionalShippingCharge { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.DeliveryDate")]
        public string DeliveryDateId { get; set; }
        public IList<SelectListItem> AvailableDeliveryDates { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.IsTaxExempt")]
        public bool IsTaxExempt { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.TaxCategory")]
        public string TaxCategoryId { get; set; }
        public IList<SelectListItem> AvailableTaxCategories { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.IsTelecommunicationsOrBroadcastingOrElectronicServices")]
        public bool IsTele { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.ManageInventoryMethod")]
        public int ManageInventoryMethodId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.UseMultipleWarehouses")]
        public bool UseMultipleWarehouses { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Warehouse")]
        public string WarehouseId { get; set; }
        public IList<SelectListItem> AvailableWarehouses { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.StockQuantity")]
        public int StockQuantity { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.StockQuantity")]
        public string StockQuantityStr { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.DisplayStockAvailability")]
        public bool DisplayStockAvailability { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.DisplayStockQuantity")]
        public bool DisplayStockQuantity { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.MinStockQuantity")]
        public int MinStockQuantity { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.LowStockActivity")]
        public int LowStockActivityId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.NotifyAdminForQuantityBelow")]
        public int NotifyAdminForQuantityBelow { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.BackorderMode")]
        public int BackorderModeId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.AllowBackInStockSubscriptions")]
        public bool AllowBackInStockSubscriptions { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.OrderMinimumQuantity")]
        public int OrderMinimumQuantity { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.OrderMaximumQuantity")]
        public int OrderMaximumQuantity { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.AllowedQuantities")]
        public string AllowedQuantities { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.AllowAddingOnlyExistingAttributeCombinations")]
        public bool AllowAddingOnlyExistingAttributeCombinations { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.NotReturnable")]
        public bool NotReturnable { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.DisableBuyButton")]
        public bool DisableBuyButton { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.DisableWishlistButton")]
        public bool DisableWishlistButton { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.AvailableForPreOrder")]
        public bool AvailableForPreOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.PreOrderAvailabilityStartDateTime")]
        [UIHint("DateTimeNullable")]
        public DateTime? PreOrderAvailabilityStartDateTime { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.CallForPrice")]
        public bool CallForPrice { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Price")]
        public decimal Price { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.OldPrice")]
        public decimal OldPrice { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.CatalogPrice")]
        public decimal CatalogPrice { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.StartPrice")]
        public decimal StartPrice { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.ProductCost")]
        public decimal ProductCost { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.CustomerEntersPrice")]
        public bool CustomerEntersPrice { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.MinimumCustomerEnteredPrice")]
        public decimal MinimumCustomerEnteredPrice { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.MaximumCustomerEnteredPrice")]
        public decimal MaximumCustomerEnteredPrice { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.BasepriceEnabled")]
        public bool BasepriceEnabled { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.BasepriceAmount")]
        public decimal BasepriceAmount { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.BasepriceUnit")]
        public string BasepriceUnitId { get; set; }
        public IList<SelectListItem> AvailableBasepriceUnits { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.BasepriceBaseAmount")]
        public decimal BasepriceBaseAmount { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.BasepriceBaseUnit")]
        public string BasepriceBaseUnitId { get; set; }
        public IList<SelectListItem> AvailableBasepriceBaseUnits { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.MarkAsNew")]
        public bool MarkAsNew { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.MarkAsNewStartDateTime")]
        [UIHint("DateTimeNullable")]
        public DateTime? MarkAsNewStartDateTime { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.MarkAsNewEndDateTime")]
        [UIHint("DateTimeNullable")]
        public DateTime? MarkAsNewEndDateTime { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Unit")]
        public string UnitId { get; set; }
        public IList<SelectListItem> AvailableUnits { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Weight")]
        public decimal Weight { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Length")]
        public decimal Length { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Width")]
        public decimal Width { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Height")]
        public decimal Height { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.AvailableStartDateTime")]
        [UIHint("DateTimeNullable")]
        public DateTime? AvailableStartDateTime { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.AvailableEndDateTime")]
        [UIHint("DateTimeNullable")]
        public DateTime? AvailableEndDateTime { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.DisplayOrderCategory")]
        public int DisplayOrderCategory { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.DisplayOrderManufacturer")]
        public int DisplayOrderManufacturer { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.DisplayOrderOnSale")]
        public int OnSale { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Published")]
        public bool Published { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.CreatedOn")]
        public DateTime? CreatedOn { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.UpdatedOn")]
        public DateTime? UpdatedOn { get; set; }
        public long Ticks { get; set; }

        public string PrimaryStoreCurrencyCode { get; set; }
        public string BaseDimensionIn { get; set; }
        public string BaseWeightIn { get; set; }

        public IList<ProductLocalizedModel> Locales { get; set; }


        //ACL (customer roles)
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.SubjectToAcl")]
        public bool SubjectToAcl { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.AclCustomerRoles")]
        public List<CustomerRoleModel> AvailableCustomerRoles { get; set; }
        public string[] SelectedCustomerRoleIds { get; set; }

        //Store mapping
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }
        public string[] SelectedStoreIds { get; set; }


        //vendor
        public bool IsLoggedInAsVendor { get; set; }



        //categories
        public IList<SelectListItem> AvailableCategories { get; set; }
        //manufacturers
        public IList<SelectListItem> AvailableManufacturers { get; set; }
        //product attributes
        public IList<SelectListItem> AvailableProductAttributes { get; set; }



        //pictures
        public ProductPictureModel AddPictureModel { get; set; }
        public IList<ProductPictureModel> ProductPictureModels { get; set; }

        //discounts
        public List<DiscountModel> AvailableDiscounts { get; set; }
        public string[] SelectedDiscountIds { get; set; }
        //add specification attribute model
        public AddProductSpecificationAttributeModel AddSpecificationAttributeModel { get; set; }
        //multiple warehouses
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductWarehouseInventory")]
        public IList<ProductWarehouseInventoryModel> ProductWarehouseInventoryModels { get; set; }

        //copy product
        public CopyProductModel CopyProductModel { get; set; }

        #region Nested classes

        public partial class AddRequiredProductModel : BaseModel
        {
            public AddRequiredProductModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableStores = new List<SelectListItem>();
                AvailableVendors = new List<SelectListItem>();
                AvailableProductTypes = new List<SelectListItem>();
            }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductName")]

            public string SearchProductName { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchCategory")]
            public string SearchCategoryId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchManufacturer")]
            public string SearchManufacturerId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchStore")]
            public string SearchStoreId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchVendor")]
            public string SearchVendorId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductType")]
            public int SearchProductTypeId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public IList<SelectListItem> AvailableVendors { get; set; }
            public IList<SelectListItem> AvailableProductTypes { get; set; }

            //vendor
            public bool IsLoggedInAsVendor { get; set; }
        }

        public partial class AddProductSpecificationAttributeModel : BaseModel
        {
            public AddProductSpecificationAttributeModel()
            {
                AvailableAttributes = new List<SelectListItem>();
                AvailableOptions = new List<SelectListItem>();
            }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.SpecificationAttribute")]
            public string SpecificationAttributeId { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.AttributeType")]
            public int AttributeTypeId { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.SpecificationAttributeOption")]
            public string SpecificationAttributeOptionId { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.CustomValue")]
            public string CustomValue { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.AllowFiltering")]
            public bool AllowFiltering { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.ShowOnProductPage")]
            public bool ShowOnProductPage { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.SpecificationAttributes.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }

            public string ProductId { get; set; }
            public IList<SelectListItem> AvailableAttributes { get; set; }
            public IList<SelectListItem> AvailableOptions { get; set; }
        }

        public partial class ProductPictureModel : BaseEntityModel
        {
            public string ProductId { get; set; }

            [UIHint("Picture")]
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Pictures.Fields.Picture")]
            public string PictureId { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Pictures.Fields.Picture")]
            public string PictureUrl { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Pictures.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Pictures.Fields.OverrideAltAttribute")]

            public string OverrideAltAttribute { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Pictures.Fields.OverrideTitleAttribute")]

            public string OverrideTitleAttribute { get; set; }
        }

        public partial class ProductCategoryModel : BaseEntityModel
        {
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Categories.Fields.Category")]
            public string Category { get; set; }

            public string ProductId { get; set; }

            public string CategoryId { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Categories.Fields.IsFeaturedProduct")]
            public bool IsFeaturedProduct { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Categories.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }
        }

        public partial class ProductManufacturerModel : BaseEntityModel
        {
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Manufacturers.Fields.Manufacturer")]
            public string Manufacturer { get; set; }

            public string ProductId { get; set; }

            public string ManufacturerId { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Manufacturers.Fields.IsFeaturedProduct")]
            public bool IsFeaturedProduct { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Manufacturers.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }
        }

        public partial class RelatedProductModel : BaseEntityModel
        {
            public string ProductId1 { get; set; }
            public string ProductId2 { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.RelatedProducts.Fields.Product")]
            public string Product2Name { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.RelatedProducts.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }
        }
        public partial class AddRelatedProductModel : BaseModel
        {
            public AddRelatedProductModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableStores = new List<SelectListItem>();
                AvailableVendors = new List<SelectListItem>();
                AvailableProductTypes = new List<SelectListItem>();
            }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductName")]

            public string SearchProductName { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchCategory")]
            public string SearchCategoryId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchManufacturer")]
            public string SearchManufacturerId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchStore")]
            public string SearchStoreId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchVendor")]
            public string SearchVendorId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductType")]
            public int SearchProductTypeId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public IList<SelectListItem> AvailableVendors { get; set; }
            public IList<SelectListItem> AvailableProductTypes { get; set; }

            public string ProductId { get; set; }

            public string[] SelectedProductIds { get; set; }

            //vendor
            public bool IsLoggedInAsVendor { get; set; }
        }

        public partial class SimilarProductModel : BaseEntityModel
        {
            public string ProductId1 { get; set; }
            public string ProductId2 { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.SimilarProducts.Fields.Product")]
            public string Product2Name { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.SimilarProducts.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }
        }

        public partial class AddSimilarProductModel : BaseModel
        {
            public AddSimilarProductModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableStores = new List<SelectListItem>();
                AvailableVendors = new List<SelectListItem>();
                AvailableProductTypes = new List<SelectListItem>();
            }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductName")]

            public string SearchProductName { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchCategory")]
            public string SearchCategoryId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchManufacturer")]
            public string SearchManufacturerId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchStore")]
            public string SearchStoreId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchVendor")]
            public string SearchVendorId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductType")]
            public int SearchProductTypeId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public IList<SelectListItem> AvailableVendors { get; set; }
            public IList<SelectListItem> AvailableProductTypes { get; set; }

            public string ProductId { get; set; }

            public string[] SelectedProductIds { get; set; }

            //vendor
            public bool IsLoggedInAsVendor { get; set; }
        }

        public partial class BundleProductModel : BaseEntityModel
        {
            public string ProductBundleId { get; set; }
            public string ProductId { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.BundleProducts.Fields.Product")]
            public string ProductName { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.BundleProducts.Fields.Quantity")]
            public int Quantity { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.BundleProducts.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }
        }

        public partial class AddBundleProductModel : BaseModel
        {
            public AddBundleProductModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableStores = new List<SelectListItem>();
                AvailableVendors = new List<SelectListItem>();
            }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductName")]

            public string SearchProductName { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchCategory")]
            public string SearchCategoryId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchManufacturer")]
            public string SearchManufacturerId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchStore")]
            public string SearchStoreId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchVendor")]
            public string SearchVendorId { get; set; }
            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public IList<SelectListItem> AvailableVendors { get; set; }

            public string ProductId { get; set; }

            public string[] SelectedProductIds { get; set; }

            //vendor
            public bool IsLoggedInAsVendor { get; set; }
        }

        public partial class AssociatedProductModel : BaseEntityModel
        {
            public string ProductId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.AssociatedProducts.Fields.Product")]
            public string ProductName { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.AssociatedProducts.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }
        }

        public partial class AddAssociatedProductModel : BaseModel
        {
            public AddAssociatedProductModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableStores = new List<SelectListItem>();
                AvailableVendors = new List<SelectListItem>();
                AvailableProductTypes = new List<SelectListItem>();
            }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductName")]

            public string SearchProductName { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchCategory")]
            public string SearchCategoryId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchManufacturer")]
            public string SearchManufacturerId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchStore")]
            public string SearchStoreId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchVendor")]
            public string SearchVendorId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductType")]
            public int SearchProductTypeId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public IList<SelectListItem> AvailableVendors { get; set; }
            public IList<SelectListItem> AvailableProductTypes { get; set; }

            public string ProductId { get; set; }

            public string[] SelectedProductIds { get; set; }

            //vendor
            public bool IsLoggedInAsVendor { get; set; }
        }

        public partial class CrossSellProductModel : BaseEntityModel
        {
            public string ProductId { get; set; }
            public string ProductId2 { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.CrossSells.Fields.Product")]
            public string Product2Name { get; set; }
        }

        public partial class AddCrossSellProductModel : BaseModel
        {
            public AddCrossSellProductModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableStores = new List<SelectListItem>();
                AvailableVendors = new List<SelectListItem>();
                AvailableProductTypes = new List<SelectListItem>();
            }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductName")]

            public string SearchProductName { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchCategory")]
            public string SearchCategoryId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchManufacturer")]
            public string SearchManufacturerId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchStore")]
            public string SearchStoreId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchVendor")]
            public string SearchVendorId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductType")]
            public int SearchProductTypeId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public IList<SelectListItem> AvailableVendors { get; set; }
            public IList<SelectListItem> AvailableProductTypes { get; set; }

            public string ProductId { get; set; }

            public string[] SelectedProductIds { get; set; }

            //vendor
            public bool IsLoggedInAsVendor { get; set; }
        }

        public partial class ProductPriceModel : BaseEntityModel
        {
            public string CurrencyCode { get; set; }

            public decimal Price { get; set; }
        }

        public partial class TierPriceModel : BaseEntityModel
        {

            public TierPriceModel()
            {
                AvailableStores = new List<SelectListItem>();
                AvailableCustomerRoles = new List<SelectListItem>();
                AvailableCurrencies = new List<SelectListItem>();
            }
            public string ProductId { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.TierPrices.Fields.CustomerRole")]
            public string CustomerRoleId { get; set; }
            public IList<SelectListItem> AvailableCustomerRoles { get; set; }
            public string CustomerRole { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.TierPrices.Fields.Store")]
            public string StoreId { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public string Store { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.TierPrices.Fields.CurrencyCode")]
            public string CurrencyCode { get; set; }
            public IList<SelectListItem> AvailableCurrencies { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.TierPrices.Fields.Quantity")]
            public int Quantity { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.TierPrices.Fields.Price")]
            public decimal Price { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.TierPrices.Fields.StartDateTime")]
            [UIHint("DateTimeNullable")]
            public DateTime? StartDateTime { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.TierPrices.Fields.EndDateTime")]
            [UIHint("DateTimeNullable")]
            public DateTime? EndDateTime { get; set; }

        }

        public partial class ProductWarehouseInventoryModel : BaseModel
        {
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductWarehouseInventory.Fields.Warehouse")]
            public string WarehouseId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductWarehouseInventory.Fields.Warehouse")]
            public string WarehouseName { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductWarehouseInventory.Fields.WarehouseUsed")]
            public bool WarehouseUsed { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductWarehouseInventory.Fields.StockQuantity")]
            public int StockQuantity { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductWarehouseInventory.Fields.ReservedQuantity")]
            public int ReservedQuantity { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductWarehouseInventory.Fields.PlannedQuantity")]
            public int PlannedQuantity { get; set; }
        }
        public partial class ReservationModel : BaseEntityModel
        {
            public string ReservationId { get; set; }
            public DateTime Date { get; set; }
            public string Resource { get; set; }
            public string Parameter { get; set; }
            public string OrderId { get; set; }
            public string ProductId { get; set; }
            public string Duration { get; set; }
        }

        public partial class BidModel : BaseEntityModel
        {
            public string ProductId { get; set; }
            public string BidId { get; set; }
            public DateTime Date { get; set; }
            public string CustomerId { get; set; }
            public string Email { get; set; }
            public string Amount { get; set; }
            public string OrderId { get; set; }
        }

        public partial class GenerateCalendarModel : BaseModel
        {

            public GenerateCalendarModel()
            {
                Interval = 1;
                Quantity = 1;
            }
            public string ProductId { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Calendar.StartDate")]
            [UIHint("DateNullable")]
            public DateTime? StartDate { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Calendar.StartTime")]
            [UIHint("Time")]
            public DateTime StartTime { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Calendar.EndDate")]
            [UIHint("DateNullable")]
            public DateTime? EndDate { get; set; }
            [UIHint("Time")]

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Calendar.EndTime")]
            public DateTime EndTime { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Calendar.Interval")]
            public int Interval { get; set; } = 1;
            public int IntervalUnit { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Calendar.IncBothDate")]
            public bool IncBothDate { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Calendar.Quantity")]
            public int Quantity { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Calendar.Resource")]
            public string Resource { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Calendar.Parameter")]
            public string Parameter { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Calendar.Monday")]
            public bool Monday { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Calendar.Tuesday")]
            public bool Tuesday { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Calendar.Wednesday")]
            public bool Wednesday { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Calendar.Thursday")]
            public bool Thursday { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Calendar.Friday")]
            public bool Friday { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Calendar.Saturday")]
            public bool Saturday { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Calendar.Sunday")]
            public bool Sunday { get; set; }

        }

        public partial class ProductAttributeMappingModel : BaseEntityModel
        {
            public ProductAttributeMappingModel()
            {
                AvailableProductAttribute = new List<SelectListItem>();
            }
            public string ProductId { get; set; }

            public string ProductAttributeId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Fields.Attribute")]
            public string ProductAttribute { get; set; }
            public IList<SelectListItem> AvailableProductAttribute { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Fields.TextPrompt")]
            public string TextPrompt { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Fields.IsRequired")]
            public bool IsRequired { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Fields.ShowOnCatalogPage")]
            public bool ShowOnCatalogPage { get; set; }
            public int AttributeControlTypeId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Fields.AttributeControlType")]
            public string AttributeControlType { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }

            public bool ShouldHaveValues { get; set; }
            public int TotalValues { get; set; }

            //validation fields
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.ValidationRules")]
            public bool ValidationRulesAllowed { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.ValidationRules.MinLength")]
            [UIHint("Int32Nullable")]
            public int? ValidationMinLength { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.ValidationRules.MaxLength")]
            [UIHint("Int32Nullable")]
            public int? ValidationMaxLength { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.ValidationRules.FileAllowedExtensions")]

            public string ValidationFileAllowedExtensions { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.ValidationRules.FileMaximumSize")]
            [UIHint("Int32Nullable")]
            public int? ValidationFileMaximumSize { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.ValidationRules.DefaultValue")]

            public string DefaultValue { get; set; }
            public string ValidationRulesString { get; set; }

            //condition
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Condition")]
            public bool ConditionAllowed { get; set; }
            public string ConditionString { get; set; }
        }
        public partial class ProductAttributeValueListModel : BaseModel
        {
            public string ProductId { get; set; }

            public string ProductName { get; set; }

            public string ProductAttributeMappingId { get; set; }

            public string ProductAttributeName { get; set; }
        }

        public partial class ProductAttributeValueModel : BaseEntityModel, ILocalizedModel<ProductAttributeValueLocalizedModel>
        {
            public ProductAttributeValueModel()
            {
                ProductPictureModels = new List<ProductPictureModel>();
                Locales = new List<ProductAttributeValueLocalizedModel>();
            }

            public string ProductAttributeMappingId { get; set; }
            public string ProductId { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.AttributeValueType")]
            public int AttributeValueTypeId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.AttributeValueType")]
            public string AttributeValueTypeName { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.AssociatedProduct")]
            public string AssociatedProductId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.AssociatedProduct")]
            public string AssociatedProductName { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.Name")]

            public string Name { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.ColorSquaresRgb")]

            public string ColorSquaresRgb { get; set; }
            public bool DisplayColorSquaresRgb { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.ImageSquaresPicture")]
            [UIHint("Picture")]
            public string ImageSquaresPictureId { get; set; }
            public bool DisplayImageSquaresPicture { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.PriceAdjustment")]
            public decimal PriceAdjustment { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.PriceAdjustment")]
            //used only on the values list page
            public string PriceAdjustmentStr { get; set; }
            public string PrimaryStoreCurrencyCode { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.WeightAdjustment")]
            public decimal WeightAdjustment { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.WeightAdjustment")]
            //used only on the values list page
            public string WeightAdjustmentStr { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.Cost")]
            public decimal Cost { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.Quantity")]
            public int Quantity { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.IsPreSelected")]
            public bool IsPreSelected { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.Picture")]
            public string PictureId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.Picture")]
            public string PictureThumbnailUrl { get; set; }

            public IList<ProductPictureModel> ProductPictureModels { get; set; }
            public IList<ProductAttributeValueLocalizedModel> Locales { get; set; }

            #region Nested classes

            public partial class AssociateProductToAttributeValueModel : BaseModel
            {
                public AssociateProductToAttributeValueModel()
                {
                    AvailableCategories = new List<SelectListItem>();
                    AvailableManufacturers = new List<SelectListItem>();
                    AvailableStores = new List<SelectListItem>();
                    AvailableVendors = new List<SelectListItem>();
                    AvailableProductTypes = new List<SelectListItem>();
                }

                [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductName")]

                public string SearchProductName { get; set; }
                [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchCategory")]
                public string SearchCategoryId { get; set; }
                [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchManufacturer")]
                public string SearchManufacturerId { get; set; }
                [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchStore")]
                public string SearchStoreId { get; set; }
                [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchVendor")]
                public string SearchVendorId { get; set; }
                [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductType")]
                public int SearchProductTypeId { get; set; }

                public IList<SelectListItem> AvailableCategories { get; set; }
                public IList<SelectListItem> AvailableManufacturers { get; set; }
                public IList<SelectListItem> AvailableStores { get; set; }
                public IList<SelectListItem> AvailableVendors { get; set; }
                public IList<SelectListItem> AvailableProductTypes { get; set; }

                //vendor
                public bool IsLoggedInAsVendor { get; set; }


                public string AssociatedToProductId { get; set; }
            }


            #endregion
        }
        public partial class ActivityLogModel : BaseEntityModel
        {
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ActivityLog.ActivityLogType")]
            public string ActivityLogTypeName { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ActivityLog.Comment")]
            public string Comment { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ActivityLog.CreatedOn")]
            public DateTime CreatedOn { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ActivityLog.Customer")]
            public string CustomerId { get; set; }
            public string CustomerEmail { get; set; }
        }
        public partial class ProductAttributeValueLocalizedModel : ILocalizedModelLocal
        {
            public string LanguageId { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.Attributes.Values.Fields.Name")]

            public string Name { get; set; }
        }
        public partial class ProductAttributeCombinationModel : BaseEntityModel
        {
            public string ProductId { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.AttributeCombinations.Fields.Attributes")]

            public string AttributesXml { get; set; }


            public string Warnings { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.AttributeCombinations.Fields.StockQuantity")]
            public int StockQuantity { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.AttributeCombinations.Fields.AllowOutOfStockOrders")]
            public bool AllowOutOfStockOrders { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.AttributeCombinations.Fields.Sku")]
            public string Sku { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.AttributeCombinations.Fields.ManufacturerPartNumber")]
            public string ManufacturerPartNumber { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.AttributeCombinations.Fields.Gtin")]
            public string Gtin { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.AttributeCombinations.Fields.OverriddenPrice")]
            [UIHint("DecimalNullable")]
            public decimal? OverriddenPrice { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.ProductAttributes.AttributeCombinations.Fields.NotifyAdminForQuantityBelow")]
            public int NotifyAdminForQuantityBelow { get; set; }

        }
        public partial class ProductAttributeCombinationTierPricesModel : BaseEntityModel
        {
            public string StoreId { get; set; }
            public string Store { get; set; }

            /// <summary>
            /// Gets or sets the customer role identifier
            /// </summary>
            public string CustomerRoleId { get; set; }
            public string CustomerRole { get; set; }

            /// <summary>
            /// Gets or sets the quantity
            /// </summary>
            public int Quantity { get; set; }

            /// <summary>
            /// Gets or sets the price
            /// </summary>
            public decimal Price { get; set; }
        }

        #endregion
    }

    public partial class ProductLocalizedModel : ILocalizedModelLocal, ISlugModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.ShortDescription")]

        public string ShortDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.FullDescription")]

        public string FullDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.MetaKeywords")]

        public string MetaKeywords { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.MetaDescription")]

        public string MetaDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.MetaTitle")]

        public string MetaTitle { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.SeName")]

        public string SeName { get; set; }
    }
}