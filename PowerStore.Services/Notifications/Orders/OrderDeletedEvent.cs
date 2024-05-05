using PowerStore.Domain.Orders;
using MediatR;

namespace PowerStore.Services.Notifications.Orders
{
    /// <summary>
    /// Order deleted event
    /// </summary>
    public class OrderDeletedEvent : INotification
    {
        public OrderDeletedEvent(Order order)
        {
            Order = order;
        }

        /// <summary>
        /// Order
        /// </summary>
        public Order Order { get; private set; }
    }
}
