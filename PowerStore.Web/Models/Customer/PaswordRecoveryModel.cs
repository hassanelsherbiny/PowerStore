using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Models.Customer
{
    public partial class PasswordRecoveryModel : BaseModel
    {
        [DataType(DataType.EmailAddress)]
        [PowerStoreResourceDisplayName("Account.PasswordRecovery.Email")]
        public string Email { get; set; }
        public string Result { get; set; }
        public bool Send { get; set; }
        public bool DisplayCaptcha { get; set; }
    }
}