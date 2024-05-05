using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Plugins
{
    public partial class MiscPluginModel : BaseModel
    {
        public string FriendlyName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Misc.Fields.Configure")]
        public string ConfigurationUrl { get; set; }
    }
}