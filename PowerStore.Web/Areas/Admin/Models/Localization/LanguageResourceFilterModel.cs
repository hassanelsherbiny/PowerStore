using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Localization
{
    public partial class LanguageResourceFilterModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.Configuration.Languages.ResourcesFilter.Fields.ResourceName")]
        public string ResourceName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Languages.ResourcesFilter.Fields.ResourceValue")]
        public string ResourceValue { get; set; }

    }
}