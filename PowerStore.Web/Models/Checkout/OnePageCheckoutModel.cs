using PowerStore.Core.Models;

namespace PowerStore.Web.Models.Checkout
{
    public partial class OnePageCheckoutModel : BaseModel
    {
        public bool ShippingRequired { get; set; }
        public bool DisableBillingAddressCheckoutStep { get; set; }
        public CheckoutBillingAddressModel BillingAddress { get; set; }
        public bool HasSinglePaymentMethod { get; set; }
    }
}