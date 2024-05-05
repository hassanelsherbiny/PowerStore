using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Directory
{
    public partial class MeasureWeightModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.Configuration.Measures.Weights.Fields.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Measures.Weights.Fields.SystemKeyword")]
        public string SystemKeyword { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Measures.Weights.Fields.Ratio")]
        public decimal Ratio { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Measures.Weights.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Measures.Weights.Fields.IsPrimaryWeight")]
        public bool IsPrimaryWeight { get; set; }
    }
}