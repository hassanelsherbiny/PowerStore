using PowerStore.Domain.Common;
using PowerStore.Domain.Customers;
using PowerStore.Domain.Directory;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Checkout;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Checkout
{
    public class GetShippingAddress : IRequest<CheckoutShippingAddressModel>
    {
        public string SelectedCountryId { get; set; } = null;
        public bool PrePopulateNewAddressWithCustomerFields { get; set; } = false;
        public IList<CustomAttribute> OverrideAttributes { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public Currency Currency { get; set; }
        public Language Language { get; set; }
    }
}
