using PowerStore.Domain.Customers;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Orders;
using MediatR;

namespace PowerStore.Web.Features.Models.Orders
{
    public class GetReturnRequests : IRequest<CustomerReturnRequestsModel>
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public Language Language { get; set; }
    }
}
