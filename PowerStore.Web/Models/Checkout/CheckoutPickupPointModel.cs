using PowerStore.Domain.Common;
using PowerStore.Core.Models;

namespace PowerStore.Web.Models.Checkout
{
    public partial class CheckoutPickupPointModel : BaseModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Address Address { get; set; }

        public string PickupFee { get; set; }

    }
}