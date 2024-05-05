using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Catalog
{
    public partial class ProductListModel : BaseModel
    {
        public ProductListModel()
        {
            AvailableCategories = new List<SelectListItem>();
            AvailableManufacturers = new List<SelectListItem>();
            AvailableStores = new List<SelectListItem>();
            AvailableWarehouses = new List<SelectListItem>();
            AvailableVendors = new List<SelectListItem>();
            AvailableProductTypes = new List<SelectListItem>();
            AvailablePublishedOptions = new List<SelectListItem>();
        }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductName")]
        public string SearchProductName { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchCategory")]
        public string SearchCategoryId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchIncludeSubCategories")]
        public bool SearchIncludeSubCategories { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchManufacturer")]
        public string SearchManufacturerId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchStore")]
        public string SearchStoreId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchVendor")]
        public string SearchVendorId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchWarehouse")]
        public string SearchWarehouseId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductType")]
        public int SearchProductTypeId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchPublished")]
        public int SearchPublishedId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.GoDirectlyToSku")]
        
        public string GoDirectlyToSku { get; set; }

        public bool IsLoggedInAsVendor { get; set; }

        public IList<SelectListItem> AvailableCategories { get; set; }
        public IList<SelectListItem> AvailableManufacturers { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }
        public IList<SelectListItem> AvailableWarehouses { get; set; }
        public IList<SelectListItem> AvailableVendors { get; set; }
        public IList<SelectListItem> AvailableProductTypes { get; set; }
        public IList<SelectListItem> AvailablePublishedOptions { get; set; }
    }
}