using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Templates
{
    public partial class CategoryTemplateModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.System.Templates.Category.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.Templates.Category.ViewPath")]

        public string ViewPath { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.Templates.Category.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}