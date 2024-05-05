using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Models.Vendors
{
    public partial class ApplyVendorModel : BaseModel
    {

        public ApplyVendorModel()
        {
            Address = new VendorAddressModel();
        }

        public VendorAddressModel Address { get; set; }

        [PowerStoreResourceDisplayName("Vendors.ApplyAccount.Name")]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [PowerStoreResourceDisplayName("Vendors.ApplyAccount.Email")]
        public string Email { get; set; }
        [PowerStoreResourceDisplayName("Vendors.ApplyAccount.Description")]
        public string Description { get; set; }
        public bool DisplayCaptcha { get; set; }
        public bool TermsOfServiceEnabled { get; set; }
        public bool TermsOfServicePopup { get; set; }
        public bool DisableFormInput { get; set; }
        public string Result { get; set; }
    }
}