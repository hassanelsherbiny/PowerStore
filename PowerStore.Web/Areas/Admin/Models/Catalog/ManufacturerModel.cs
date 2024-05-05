using PowerStore.Framework.Localization;
using PowerStore.Framework.Mapping;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using PowerStore.Web.Areas.Admin.Models.Discounts;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PowerStore.Framework.Mvc.Models;

namespace PowerStore.Web.Areas.Admin.Models.Catalog
{
    public partial class ManufacturerModel : BaseEntityModel, ILocalizedModel<ManufacturerLocalizedModel>, IAclMappingModel, IStoreMappingModel
    {
        public ManufacturerModel()
        {
            if (PageSize < 1)
            {
                PageSize = 5;
            }
            Locales = new List<ManufacturerLocalizedModel>();
            AvailableManufacturerTemplates = new List<SelectListItem>();
            AvailableStores = new List<StoreModel>();
            AvailableCustomerRoles = new List<CustomerRoleModel>();
            AvailableSortOptions = new List<SelectListItem>();
        }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.Description")]

        public string Description { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.BottomDescription")]

        public string BottomDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.ManufacturerTemplate")]
        public string ManufacturerTemplateId { get; set; }
        public IList<SelectListItem> AvailableManufacturerTemplates { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.MetaKeywords")]

        public string MetaKeywords { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.MetaDescription")]

        public string MetaDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.MetaTitle")]

        public string MetaTitle { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.SeName")]

        public string SeName { get; set; }

        [UIHint("Picture")]
        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.Picture")]
        public string PictureId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.PageSize")]
        public int PageSize { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.AllowCustomersToSelectPageSize")]
        public bool AllowCustomersToSelectPageSize { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.PageSizeOptions")]
        public string PageSizeOptions { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.PriceRanges")]

        public string PriceRanges { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.ShowOnHomePage")]
        public bool ShowOnHomePage { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.FeaturedProductsOnHomaPage")]
        public bool FeaturedProductsOnHomaPage { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.IncludeInTopMenu")]
        public bool IncludeInTopMenu { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.Icon")]
        public string Icon { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.DefaultSort")]
        public int DefaultSort { get; set; }
        public IList<SelectListItem> AvailableSortOptions { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.Published")]
        public bool Published { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.Deleted")]
        public bool Deleted { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<ManufacturerLocalizedModel> Locales { get; set; }

        //ACL
        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.SubjectToAcl")]
        public bool SubjectToAcl { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.AclCustomerRoles")]
        public List<CustomerRoleModel> AvailableCustomerRoles { get; set; }
        public string[] SelectedCustomerRoleIds { get; set; }

        //Store mapping
        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }
        public string[] SelectedStoreIds { get; set; }


        //discounts
        public List<DiscountModel> AvailableDiscounts { get; set; }
        public string[] SelectedDiscountIds { get; set; }


        #region Nested classes
        public partial class ManufacturerProductModel : BaseEntityModel
        {
            public string ManufacturerId { get; set; }

            public string ProductId { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Products.Fields.Product")]
            public string ProductName { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Products.Fields.IsFeaturedProduct")]
            public bool IsFeaturedProduct { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Products.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }
        }

        public partial class AddManufacturerProductModel : BaseModel
        {
            public AddManufacturerProductModel()
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

            public string ManufacturerId { get; set; }

            public string[] SelectedProductIds { get; set; }
        }

        public partial class ActivityLogModel : BaseEntityModel
        {
            [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.ActivityLog.ActivityLogType")]
            public string ActivityLogTypeName { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.ActivityLog.Comment")]
            public string Comment { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.ActivityLog.CreatedOn")]
            public DateTime CreatedOn { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.ActivityLog.Customer")]
            public string CustomerId { get; set; }
            public string CustomerEmail { get; set; }
        }



        #endregion
    }

    public partial class ManufacturerLocalizedModel : ILocalizedModelLocal, ISlugModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.Description")]

        public string Description { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.BottomDescription")]

        public string BottomDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.MetaKeywords")]

        public string MetaKeywords { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.MetaDescription")]

        public string MetaDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.MetaTitle")]

        public string MetaTitle { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Manufacturers.Fields.SeName")]

        public string SeName { get; set; }
    }
}