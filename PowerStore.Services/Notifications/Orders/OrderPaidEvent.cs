using PowerStore.Domain.Orders;
using MediatR;

namespace PowerStore.Services.Notifications.Orders
{
    /// <summary>
    /// Order paid event
    /// </summary>
    public class OrderPaidEvent : INotification
    {
        public OrderPaidEvent(Order order)
        {
            Order = order;
        }

        /// <summary>
        /// Order
        /// </summary>
        public Order Order { get; private set; }
    }

}
