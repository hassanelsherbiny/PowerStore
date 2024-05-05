using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Models.Vendors
{
    public partial class VendorInfoModel : BaseModel
    {
        public VendorInfoModel()
        {
            Address = new VendorAddressModel();
        }

        [PowerStoreResourceDisplayName("Account.VendorInfo.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Account.VendorInfo.Email")]
        public string Email { get; set; }

        [PowerStoreResourceDisplayName("Account.VendorInfo.Description")]
        public string Description { get; set; }

        [PowerStoreResourceDisplayName("Account.VendorInfo.Picture")]
        public string PictureUrl { get; set; }

        public VendorAddressModel Address { get; set; }
    }
}