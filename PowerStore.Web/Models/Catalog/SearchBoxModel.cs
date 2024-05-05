using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PowerStore.Web.Models.Catalog
{
    public partial class SearchBoxModel : BaseModel
    {
        public SearchBoxModel()
        {
            AvailableCategories = new List<SelectListItem>();
        }
        public bool AutoCompleteEnabled { get; set; }
        public bool ShowProductImagesInSearchAutoComplete { get; set; }
        public int SearchTermMinimumLength { get; set; }
        public string SearchCategoryId { get; set; }
        public bool Box { get; set; }
        public IList<SelectListItem> AvailableCategories { get; set; }
    }
}