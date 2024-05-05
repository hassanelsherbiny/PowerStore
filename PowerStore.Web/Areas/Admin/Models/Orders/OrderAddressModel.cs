using PowerStore.Core.Models;
using PowerStore.Web.Areas.Admin.Models.Common;

namespace PowerStore.Web.Areas.Admin.Models.Orders
{
    public partial class OrderAddressModel : BaseModel
    {
        public string OrderId { get; set; }
        public bool BillingAddress { get; set; }
        public AddressModel Address { get; set; }
    }
}