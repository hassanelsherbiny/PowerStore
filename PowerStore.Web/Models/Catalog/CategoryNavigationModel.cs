using PowerStore.Core.Models;
using System.Collections.Generic;

namespace PowerStore.Web.Models.Catalog
{
    public partial class CategoryNavigationModel : BaseModel
    {
        public CategoryNavigationModel()
        {
            Categories = new List<CategorySimpleModel>();
        }

        public string CurrentCategoryId { get; set; }
        public List<CategorySimpleModel> Categories { get; set; }

        public class CategoryLineModel : BaseModel
        {
            public string CurrentCategoryId { get; set; }
            public CategorySimpleModel Category { get; set; }
        }
    }
}