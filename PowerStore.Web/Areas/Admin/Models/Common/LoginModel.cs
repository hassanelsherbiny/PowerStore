using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Areas.Admin.Models.Common
{
    public partial class LoginModel : BaseModel
    {

        [DataType(DataType.EmailAddress)]
        [PowerStoreResourceDisplayName("Account.Login.Fields.Email")]
        public string Email { get; set; }

        public bool UsernamesEnabled { get; set; }
        [PowerStoreResourceDisplayName("Account.Login.Fields.UserName")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        [PowerStoreResourceDisplayName("Account.Login.Fields.Password")]
        public string Password { get; set; }

        [PowerStoreResourceDisplayName("Account.Login.Fields.RememberMe")]
        public bool RememberMe { get; set; }

        public bool DisplayCaptcha { get; set; }

    }
}