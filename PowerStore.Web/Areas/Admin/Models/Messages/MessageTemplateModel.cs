using PowerStore.Framework.Localization;
using PowerStore.Framework.Mapping;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PowerStore.Framework.Mvc.Models;

namespace PowerStore.Web.Areas.Admin.Models.Messages
{
    public partial class MessageTemplateModel : BaseEntityModel, ILocalizedModel<MessageTemplateLocalizedModel>, IStoreMappingModel
    {
        public MessageTemplateModel()
        {
            Locales = new List<MessageTemplateLocalizedModel>();
            AvailableEmailAccounts = new List<EmailAccountModel>();
            AvailableStores = new List<StoreModel>();
        }


        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.Fields.AllowedTokens")]
        public string[] AllowedTokens { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.Fields.BccEmailAddresses")]

        public string BccEmailAddresses { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.Fields.Subject")]

        public string Subject { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.Fields.Body")]

        public string Body { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.Fields.IsActive")]

        public bool IsActive { get; set; }
        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.Fields.SendImmediately")]
        public bool SendImmediately { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.Fields.DelayBeforeSend")]
        [UIHint("Int32Nullable")]
        public int? DelayBeforeSend { get; set; }
        public int DelayPeriodId { get; set; }

        public bool HasAttachedDownload { get; set; }
        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.Fields.AttachedDownload")]
        [UIHint("Download")]
        public string AttachedDownloadId { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.Fields.EmailAccount")]
        public string EmailAccountId { get; set; }
        public IList<EmailAccountModel> AvailableEmailAccounts { get; set; }

        //Store mapping
        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.Fields.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.Fields.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }
        public string[] SelectedStoreIds { get; set; }
        //comma-separated list of stores used on the list page
        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.Fields.LimitedToStores")]
        public string ListOfStores { get; set; }



        public IList<MessageTemplateLocalizedModel> Locales { get; set; }
    }

    public partial class MessageTemplateLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.Fields.BccEmailAddresses")]

        public string BccEmailAddresses { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.Fields.Subject")]

        public string Subject { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.Fields.Body")]

        public string Body { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.Fields.EmailAccount")]
        public string EmailAccountId { get; set; }
    }
}