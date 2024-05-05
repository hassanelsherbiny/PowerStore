using PowerStore.Core.Models;
using PowerStore.Web.Models.Common;

namespace PowerStore.Web.Models.Customer
{
    public partial class CustomerAddressEditModel : BaseModel
    {
        public CustomerAddressEditModel()
        {
            Address = new AddressModel();
        }
        public AddressModel Address { get; set; }
    }
}