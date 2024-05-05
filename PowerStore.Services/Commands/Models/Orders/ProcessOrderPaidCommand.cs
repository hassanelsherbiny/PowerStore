using PowerStore.Domain.Orders;
using MediatR;

namespace PowerStore.Services.Commands.Models.Orders
{
    public class ProcessOrderPaidCommand : IRequest<bool>
    {
        public Order Order { get; set; }
    }
}
