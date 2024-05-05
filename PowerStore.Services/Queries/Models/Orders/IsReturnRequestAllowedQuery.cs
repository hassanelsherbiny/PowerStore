using PowerStore.Domain.Orders;
using MediatR;

namespace PowerStore.Services.Queries.Models.Orders
{
    public class IsReturnRequestAllowedQuery : IRequest<bool>
    {
        public Order Order { get; set; }
    }
}
