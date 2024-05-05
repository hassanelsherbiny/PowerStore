using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System;

namespace PowerStore.Web.Areas.Admin.Models.Messages
{
    public partial class ContactFormModel: BaseEntityModel
    {
        public override string Id { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.ContactForm.Fields.Store")]
        public string Store { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.ContactForm.Fields.Email")]
        public string Email { get; set; }
        public string FullName { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.ContactForm.Fields.IpAddress")]
        public string IpAddress { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.ContactForm.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.ContactForm.Fields.Subject")]
        public string Subject { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.ContactForm.Fields.Enquiry")]
        public string Enquiry { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.ContactForm.Fields.ContactAttributeDescription")]
        public string ContactAttributeDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.ContactForm.Fields.EmailAccountName")]
        
        public string EmailAccountName { get; set; }
    }
}