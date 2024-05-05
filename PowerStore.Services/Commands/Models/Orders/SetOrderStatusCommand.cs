using PowerStore.Domain.Orders;
using MediatR;

namespace PowerStore.Services.Commands.Models.Orders
{
    public class SetOrderStatusCommand : IRequest<bool>
    {
        public Order Order { get; set; }
        public OrderStatus Os { get; set; }
        public bool NotifyCustomer { get; set; }
        public bool NotifyStoreOwner { get; set; }
    }
}
