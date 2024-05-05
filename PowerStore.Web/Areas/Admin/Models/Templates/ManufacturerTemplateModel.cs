using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Templates
{
    public partial class ManufacturerTemplateModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.System.Templates.Manufacturer.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.Templates.Manufacturer.ViewPath")]

        public string ViewPath { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.Templates.Manufacturer.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}