using PowerStore.Core.Models;
using PowerStore.Web.Models.Common;
using System.Collections.Generic;

namespace PowerStore.Web.Models.Checkout
{
    public partial class CheckoutBillingAddressModel : BaseModel
    {
        public CheckoutBillingAddressModel()
        {
            ExistingAddresses = new List<AddressModel>();
            NewAddress = new AddressModel();
        }

        public IList<AddressModel> ExistingAddresses { get; set; }

        public AddressModel NewAddress { get; set; }

        public bool ShipToSameAddress { get; set; }
        public bool ShipToSameAddressAllowed { get; set; }
        /// <summary>
        /// Used on one-page checkout page
        /// </summary>
        public bool NewAddressPreselected { get; set; }
    }
}