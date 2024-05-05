using PowerStore.Core.Models;
using PowerStore.Web.Areas.Admin.Models.Common;

namespace PowerStore.Web.Areas.Admin.Models.Customers
{
    public partial class CustomerAddressModel : BaseModel
    {
        public string CustomerId { get; set; }

        public AddressModel Address { get; set; }
    }
}