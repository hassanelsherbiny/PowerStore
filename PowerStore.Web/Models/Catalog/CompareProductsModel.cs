using PowerStore.Core.Models;
using System.Collections.Generic;

namespace PowerStore.Web.Models.Catalog
{
    public partial class CompareProductsModel : BaseEntityModel
    {
        public CompareProductsModel()
        {
            Products = new List<ProductOverviewModel>();
        }
        public IList<ProductOverviewModel> Products { get; set; }

        public bool IncludeShortDescriptionInCompareProducts { get; set; }
        public bool IncludeFullDescriptionInCompareProducts { get; set; }
    }
}