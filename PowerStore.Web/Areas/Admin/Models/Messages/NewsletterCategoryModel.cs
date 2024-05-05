using PowerStore.Framework.Localization;
using PowerStore.Framework.Mapping;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.Collections.Generic;
using PowerStore.Framework.Mvc.Models;

namespace PowerStore.Web.Areas.Admin.Models.Messages
{
    public partial class NewsletterCategoryModel : BaseEntityModel, ILocalizedModel<NewsletterCategoryLocalizedModel>, IStoreMappingModel
    {
        public NewsletterCategoryModel()
        {
            Locales = new List<NewsletterCategoryLocalizedModel>();
            AvailableStores = new List<StoreModel>();
        }

        [PowerStoreResourceDisplayName("Admin.Promotions.NewsletterCategory.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.NewsletterCategory.Fields.Description")]

        public string Description { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.NewsletterCategory.Fields.Selected")]
        public bool Selected { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.NewsletterCategory.Fields.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.NewsletterCategory.Fields.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        public string[] SelectedStoreIds { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.NewsletterCategory.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }
        public IList<NewsletterCategoryLocalizedModel> Locales { get; set; }
    }

    public partial class NewsletterCategoryLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.NewsletterCategory.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.NewsletterCategory.Fields.Description")]

        public string Description { get; set; }

    }
}