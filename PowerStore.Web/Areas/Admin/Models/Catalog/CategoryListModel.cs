using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Catalog
{
    public partial class CategoryListModel : BaseModel
    {
        public CategoryListModel()
        {
            AvailableStores = new List<SelectListItem>();
        }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.List.SearchCategoryName")]

        public string SearchCategoryName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.List.SearchStore")]
        public string SearchStoreId { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }
    }
}