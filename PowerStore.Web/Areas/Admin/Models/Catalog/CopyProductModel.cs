using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Catalog
{
    public partial class CopyProductModel : BaseEntityModel
    {

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Copy.Name")]
        
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Copy.CopyImages")]
        public bool CopyImages { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Products.Copy.Published")]
        public bool Published { get; set; }

    }
}