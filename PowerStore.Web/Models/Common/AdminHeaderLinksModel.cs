using PowerStore.Core.Models;

namespace PowerStore.Web.Models.Common
{
    public partial class AdminHeaderLinksModel : BaseModel
    {
        public string ImpersonatedCustomerEmailUsername { get; set; }
        public bool IsCustomerImpersonated { get; set; }
        public bool DisplayAdminLink { get; set; }
        public string EditPageUrl { get; set; }
    }
}