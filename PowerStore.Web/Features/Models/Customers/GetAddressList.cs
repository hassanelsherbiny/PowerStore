using PowerStore.Domain.Customers;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Customer;
using MediatR;

namespace PowerStore.Web.Features.Models.Customers
{
    public class GetAddressList : IRequest<CustomerAddressListModel>
    {
        public Store Store { get; set; }
        public Customer Customer { get; set; }
        public Language Language { get; set; }
    }
}
