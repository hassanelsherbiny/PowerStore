using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Models.Customer
{
    public partial class DeleteAccountModel : BaseModel
    {
        [DataType(DataType.Password)]
        [PowerStoreResourceDisplayName("Account.DeleteAccount.Fields.Password")]
        public string Password { get; set; }

    }
}