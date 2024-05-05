using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Settings
{
    public partial class SettingModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AllSettings.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AllSettings.Fields.Value")]

        public string Value { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AllSettings.Fields.StoreName")]
        public string Store { get; set; }
        public string StoreId { get; set; }
    }
}