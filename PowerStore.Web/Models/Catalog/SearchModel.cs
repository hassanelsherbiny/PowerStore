using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PowerStore.Web.Models.Catalog
{
    public partial class SearchModel : BaseModel
    {
        public SearchModel()
        {
            PagingFilteringContext = new CatalogPagingFilteringModel();
            Products = new List<ProductOverviewModel>();
            AvailableCategories = new List<SelectListItem>();
            AvailableManufacturers = new List<SelectListItem>();
            AvailableVendors = new List<SelectListItem>();
        }

        public string Warning { get; set; }

        public bool NoResults { get; set; }

        /// <summary>
        /// Query string
        /// </summary>
        [PowerStoreResourceDisplayName("Search.SearchTerm")]
        public string q { get; set; }
        /// <summary>
        /// Category ID
        /// </summary>
        [PowerStoreResourceDisplayName("Search.Category")]
        public string cid { get; set; }
        [PowerStoreResourceDisplayName("Search.IncludeSubCategories")]
        public bool isc { get; set; }
        /// <summary>
        /// Manufacturer ID
        /// </summary>
        [PowerStoreResourceDisplayName("Search.Manufacturer")]
        public string mid { get; set; }
        /// <summary>
        /// Vendor ID
        /// </summary>
        [PowerStoreResourceDisplayName("Search.Vendor")]
        public string vid { get; set; }
        /// <summary>
        /// Price - From 
        /// </summary>
        [PowerStoreResourceDisplayName("Search.PriceRange.From")]
        public string pf { get; set; }
        /// <summary>
        /// Price - To
        /// </summary>
        [PowerStoreResourceDisplayName("Search.PriceRange.To")]
        public string pt { get; set; }
        /// <summary>
        /// A value indicating whether to search in descriptions
        /// </summary>
        [PowerStoreResourceDisplayName("Search.SearchInDescriptions")]
        public bool sid { get; set; }
        /// <summary>
        /// A value indicating whether "advanced search" is enabled
        /// </summary>
        [PowerStoreResourceDisplayName("Search.AdvancedSearch")]
        public bool adv { get; set; }
        /// <summary>
        /// A value indicating whether "allow search by vendor" is enabled
        /// </summary>
        public bool asv { get; set; }
        public bool Box { get; set; }

        public IList<SelectListItem> AvailableCategories { get; set; }
        public IList<SelectListItem> AvailableManufacturers { get; set; }
        public IList<SelectListItem> AvailableVendors { get; set; }

        public CatalogPagingFilteringModel PagingFilteringContext { get; set; }
        public IList<ProductOverviewModel> Products { get; set; }

        #region Nested classes

        public class CategoryModel : BaseEntityModel
        {
            public string Breadcrumb { get; set; }
        }

        #endregion
    }
}