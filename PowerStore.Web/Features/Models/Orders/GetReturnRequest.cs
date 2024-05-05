using PowerStore.Domain.Customers;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Orders;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Orders;
using MediatR;

namespace PowerStore.Web.Features.Models.Orders
{
    public class GetReturnRequest : IRequest<ReturnRequestModel>
    {
        public Order Order { get; set; }
        public Language Language { get; set; }
        public Store Store { get; set; }
    }
}
