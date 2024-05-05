using PowerStore.Domain.Orders;
using MediatR;

namespace PowerStore.Services.Notifications.Orders
{
    /// <summary>
    /// Order cancelled event
    /// </summary>
    public class OrderCancelledEvent : INotification
    {
        public OrderCancelledEvent(Order order)
        {
            Order = order;
        }

        /// <summary>
        /// Order
        /// </summary>
        public Order Order { get; private set; }
    }
}
