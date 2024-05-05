using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.ExternalAuthentication
{
    public partial class AuthenticationMethodModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Admin.Configuration.ExternalAuthenticationMethods.Fields.FriendlyName")]
        
        public string FriendlyName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.ExternalAuthenticationMethods.Fields.SystemName")]
        
        public string SystemName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.ExternalAuthenticationMethods.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.ExternalAuthenticationMethods.Fields.IsActive")]
        public bool IsActive { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.ExternalAuthenticationMethods.Fields.Configure")]
        public string ConfigurationUrl { get; set; }
    }
}