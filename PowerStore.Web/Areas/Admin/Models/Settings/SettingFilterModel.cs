using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Settings
{
    public partial class SettingFilterModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.Filter.Name")]
        public string SettingFilterName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.Filter.Value")]
        public string SettingFilterValue { get; set; }

    }
}