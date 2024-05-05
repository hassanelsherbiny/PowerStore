using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Cms
{
    public partial class WidgetModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Admin.ContentManagement.Widgets.Fields.FriendlyName")]
        
        public string FriendlyName { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Widgets.Fields.SystemName")]
        
        public string SystemName { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Widgets.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Widgets.Fields.IsActive")]
        public bool IsActive { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Widgets.Fields.Configure")]
        public string ConfigurationUrl { get; set; }
    }
}