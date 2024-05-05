using PowerStore.Framework.Localization;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Settings
{
    public partial class ReturnRequestActionModel : BaseEntityModel, ILocalizedModel<ReturnRequestActionLocalizedModel>
    {
        public ReturnRequestActionModel()
        {
            Locales = new List<ReturnRequestActionLocalizedModel>();
        }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.Order.ReturnRequestActions.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.Order.ReturnRequestActions.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<ReturnRequestActionLocalizedModel> Locales { get; set; }
    }

    public partial class ReturnRequestActionLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.Order.ReturnRequestActions.Name")]

        public string Name { get; set; }

    }
}