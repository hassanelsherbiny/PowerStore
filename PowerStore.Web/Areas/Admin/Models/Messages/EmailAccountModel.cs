using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Messages
{
    public partial class EmailAccountModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.Email")]
        public string Email { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.DisplayName")]
        public string DisplayName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.Host")]
        public string Host { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.Port")]
        public int Port { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.Username")]
        public string Username { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.Password")]
        public string Password { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.UseServerCertificateValidation")]
        public bool UseServerCertificateValidation { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.SecureSocketOptions")]
        public int SecureSocketOptionsId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.IsDefaultEmailAccount")]
        public bool IsDefaultEmailAccount { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.EmailAccounts.Fields.SendTestEmailTo")]
        public string SendTestEmailTo { get; set; }

    }
}