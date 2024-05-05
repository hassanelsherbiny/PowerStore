using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Models.Customer
{
    public partial class ChangePasswordModel : BaseModel
    {
        [DataType(DataType.Password)]
        [PowerStoreResourceDisplayName("Account.ChangePassword.Fields.OldPassword")]
        public string OldPassword { get; set; }

        [DataType(DataType.Password)]
        [PowerStoreResourceDisplayName("Account.ChangePassword.Fields.NewPassword")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [PowerStoreResourceDisplayName("Account.ChangePassword.Fields.ConfirmNewPassword")]
        public string ConfirmNewPassword { get; set; }

        public string Result { get; set; }

    }
}