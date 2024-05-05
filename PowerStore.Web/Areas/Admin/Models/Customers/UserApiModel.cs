using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Customers
{
    public partial class UserApiModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.System.UserApi.Email")]
        public string Email { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.UserApi.Password")]
        public string Password { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.UserApi.IsActive")]
        public bool IsActive { get; set; }

    }
}
