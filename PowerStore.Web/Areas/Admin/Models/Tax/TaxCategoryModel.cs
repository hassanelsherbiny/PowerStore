using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Tax
{
    public partial class TaxCategoryModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.Configuration.Tax.Categories.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Tax.Categories.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}