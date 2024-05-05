using PowerStore.Core.Models;

namespace PowerStore.Web.Models.Checkout
{
    public partial class CheckoutPaymentInfoModel : BaseModel
    {
        public string PaymentViewComponentName { get; set; }

        /// <summary>
        /// Used on one-page checkout page
        /// </summary>
        public bool DisplayOrderTotals { get; set; }
    }
}