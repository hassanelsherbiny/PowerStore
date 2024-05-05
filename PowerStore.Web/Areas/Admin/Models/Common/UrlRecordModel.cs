using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Common
{
    public partial class UrlRecordModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.System.SeNames.Name")]
        
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.SeNames.EntityId")]
        public string EntityId { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.SeNames.EntityName")]
        public string EntityName { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.SeNames.IsActive")]
        public bool IsActive { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.SeNames.Language")]
        public string Language { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.SeNames.Details")]
        public string DetailsUrl { get; set; }
    }
}