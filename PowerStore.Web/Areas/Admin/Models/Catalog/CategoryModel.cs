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
    public partial class CategoryModel : BaseEntityModel, ILocalizedModel<CategoryLocalizedModel>, IAclMappingModel, IStoreMappingModel
    {
        public CategoryModel()
        {
            if (PageSize < 1)
            {
                PageSize = 5;
            }
            Locales = new List<CategoryLocalizedModel>();
            AvailableCategoryTemplates = new List<SelectListItem>();
            AvailableCategories = new List<SelectListItem>();
            AvailableSortOptions = new List<SelectListItem>();
        }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.Description")]

        public string Description { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.BottomDescription")]

        public string BottomDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.CategoryTemplate")]
        public string CategoryTemplateId { get; set; }
        public IList<SelectListItem> AvailableCategoryTemplates { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.MetaKeywords")]

        public string MetaKeywords { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.MetaDescription")]

        public string MetaDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.MetaTitle")]

        public string MetaTitle { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.SeName")]

        public string SeName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.Parent")]
        public string ParentCategoryId { get; set; }

        [UIHint("Picture")]
        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.Picture")]
        public string PictureId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.PageSize")]
        public int PageSize { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.AllowCustomersToSelectPageSize")]
        public bool AllowCustomersToSelectPageSize { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.PageSizeOptions")]
        public string PageSizeOptions { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.PriceRanges")]

        public string PriceRanges { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.ShowOnHomePage")]
        public bool ShowOnHomePage { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.FeaturedProductsOnHomaPage")]
        public bool FeaturedProductsOnHomaPage { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.IncludeInTopMenu")]
        public bool IncludeInTopMenu { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.Published")]
        public bool Published { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.Deleted")]
        public bool Deleted { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.Flag")]
        public string Flag { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.FlagStyle")]
        public string FlagStyle { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.Icon")]
        public string Icon { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.HideOnCatalog")]
        public bool HideOnCatalog { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.DefaultSort")]
        public int DefaultSort { get; set; }
        public IList<SelectListItem> AvailableSortOptions { get; set; }


        public IList<CategoryLocalizedModel> Locales { get; set; }

        public string Breadcrumb { get; set; }

        //seach box
        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.ShowOnSearchBox")]
        public bool ShowOnSearchBox { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.SearchBoxDisplayOrder")]
        public int SearchBoxDisplayOrder { get; set; }

        //ACL
        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.SubjectToAcl")]
        public bool SubjectToAcl { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.AclCustomerRoles")]
        public List<CustomerRoleModel> AvailableCustomerRoles { get; set; }
        public string[] SelectedCustomerRoleIds { get; set; }

        //Store mapping
        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }
        public string[] SelectedStoreIds { get; set; }

        public IList<SelectListItem> AvailableCategories { get; set; }


        //discounts
        public List<DiscountModel> AvailableDiscounts { get; set; }
        public string[] SelectedDiscountIds { get; set; }


        #region Nested classes
        public partial class CategoryProductModel : BaseEntityModel
        {
            public string CategoryId { get; set; }

            public string ProductId { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Products.Fields.Product")]
            public string ProductName { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Products.Fields.IsFeaturedProduct")]
            public bool IsFeaturedProduct { get; set; }

            [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Products.Fields.DisplayOrder")]
            public int DisplayOrder { get; set; }
        }
        public partial class AddCategoryProductModel : BaseModel
        {
            public AddCategoryProductModel()
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

            public string CategoryId { get; set; }

            public string[] SelectedProductIds { get; set; }
        }

        public partial class ActivityLogModel : BaseEntityModel
        {
            [PowerStoreResourceDisplayName("Admin.Catalog.Categories.ActivityLogType")]
            public string ActivityLogTypeName { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Categories.ActivityLog.Comment")]
            public string Comment { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Categories.ActivityLog.CreatedOn")]
            public DateTime CreatedOn { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Categories.ActivityLog.Customer")]
            public string CustomerId { get; set; }
            public string CustomerEmail { get; set; }
        }


        #endregion
    }

    public partial class CategoryLocalizedModel : ILocalizedModelLocal, ISlugModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.Description")]

        public string Description { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.BottomDescription")]

        public string BottomDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.MetaKeywords")]

        public string MetaKeywords { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.MetaDescription")]

        public string MetaDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.MetaTitle")]

        public string MetaTitle { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.SeName")]

        public string SeName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Fields.Flag")]
        public string Flag { get; set; }
    }

}