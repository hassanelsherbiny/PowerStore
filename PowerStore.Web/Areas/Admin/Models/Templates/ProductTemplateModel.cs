using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Templates
{
    public partial class ProductTemplateModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.System.Templates.Product.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.Templates.Product.ViewPath")]

        public string ViewPath { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.Templates.Product.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}