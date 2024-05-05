using PowerStore.Framework.Localization;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Messages
{
    public partial class BannerModel : BaseEntityModel, ILocalizedModel<BannerLocalizedModel>
    {
        public BannerModel()
        {
            Locales = new List<BannerLocalizedModel>();
        }

        [PowerStoreResourceDisplayName("Admin.Promotions.Banners.Fields.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.Banners.Fields.Body")]

        public string Body { get; set; }

        public IList<BannerLocalizedModel> Locales { get; set; }

    }

    public partial class BannerLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.Banners.Fields.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.Banners.Fields.Body")]

        public string Body { get; set; }

    }

}