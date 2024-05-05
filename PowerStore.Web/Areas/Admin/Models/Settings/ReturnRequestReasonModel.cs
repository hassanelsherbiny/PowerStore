using PowerStore.Framework.Localization;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Settings
{
    public partial class ReturnRequestReasonModel : BaseEntityModel, ILocalizedModel<ReturnRequestReasonLocalizedModel>
    {
        public ReturnRequestReasonModel()
        {
            Locales = new List<ReturnRequestReasonLocalizedModel>();
        }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.Order.ReturnRequestReasons.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.Order.ReturnRequestReasons.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<ReturnRequestReasonLocalizedModel> Locales { get; set; }
    }

    public partial class ReturnRequestReasonLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.Order.ReturnRequestReasons.Name")]

        public string Name { get; set; }

    }
}