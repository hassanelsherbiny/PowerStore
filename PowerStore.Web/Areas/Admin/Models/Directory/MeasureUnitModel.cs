using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Directory
{
    public partial class MeasureUnitModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.Configuration.Measures.Units.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Measures.Units.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

    }
}