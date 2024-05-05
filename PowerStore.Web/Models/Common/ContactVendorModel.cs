using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Models.Common
{
    public partial class ContactVendorModel : BaseModel
    {
        public string VendorId { get; set; }
        public string VendorName { get; set; }

        [DataType(DataType.EmailAddress)]
        [PowerStoreResourceDisplayName("ContactVendor.Email")]
        public string Email { get; set; }

        [PowerStoreResourceDisplayName("ContactVendor.Subject")]
        public string Subject { get; set; }
        public bool SubjectEnabled { get; set; }

        [PowerStoreResourceDisplayName("ContactVendor.Enquiry")]
        public string Enquiry { get; set; }

        [PowerStoreResourceDisplayName("ContactVendor.FullName")]
        public string FullName { get; set; }

        public bool SuccessfullySent { get; set; }
        public string Result { get; set; }

        public bool DisplayCaptcha { get; set; }
    }
}