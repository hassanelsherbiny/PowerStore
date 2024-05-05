using PowerStore.Domain.Customers;
using PowerStore.Domain.Stores;
using MediatR;

namespace PowerStore.Web.Features.Models.Checkout
{
    public class GetMinOrderPlaceIntervalValid : IRequest<bool>
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }
    }
}
