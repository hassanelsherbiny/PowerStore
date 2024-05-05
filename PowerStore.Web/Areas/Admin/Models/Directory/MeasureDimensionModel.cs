using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Directory
{
    public partial class MeasureDimensionModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.Configuration.Measures.Dimensions.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Measures.Dimensions.Fields.SystemKeyword")]

        public string SystemKeyword { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Measures.Dimensions.Fields.Ratio")]
        public decimal Ratio { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Measures.Dimensions.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Measures.Dimensions.Fields.IsPrimaryDimension")]
        public bool IsPrimaryDimension { get; set; }
    }
}