using PowerStore.Framework.Localization;
using PowerStore.Framework.Mapping;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.Collections.Generic;
using PowerStore.Framework.Mvc.Models;

namespace PowerStore.Web.Areas.Admin.Models.Plugins
{
    public partial class PluginModel : BaseModel, ILocalizedModel<PluginLocalizedModel>, IStoreMappingModel
    {
        public PluginModel()
        {
            Locales = new List<PluginLocalizedModel>();
            AvailableStores = new List<StoreModel>();
        }
        [PowerStoreResourceDisplayName("Admin.Configuration.Plugins.Fields.Group")]

        public string Group { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Plugins.Fields.FriendlyName")]

        public string FriendlyName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Plugins.Fields.SystemName")]

        public string SystemName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Plugins.Fields.Version")]

        public string Version { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Plugins.Fields.Author")]

        public string Author { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Plugins.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Plugins.Fields.Configure")]
        public string ConfigurationUrl { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Plugins.Fields.Installed")]
        public bool Installed { get; set; }

        public bool CanChangeEnabled { get; set; }
        [PowerStoreResourceDisplayName("Admin.Configuration.Plugins.Fields.IsEnabled")]
        public bool IsEnabled { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Plugins.Fields.Logo")]
        public string LogoUrl { get; set; }

        public IList<PluginLocalizedModel> Locales { get; set; }


        //Store mapping
        [PowerStoreResourceDisplayName("Admin.Configuration.Plugins.Fields.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        [PowerStoreResourceDisplayName("Admin.Configuration.Plugins.Fields.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }
        public string[] SelectedStoreIds { get; set; }
    }
    public partial class PluginLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Plugins.Fields.FriendlyName")]

        public string FriendlyName { get; set; }
    }
}