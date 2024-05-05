using PowerStore.Domain.Orders;
using MediatR;

namespace PowerStore.Services.Notifications.Orders
{
    /// <summary>
    /// Order void offline event
    /// </summary>
    public class OrderVoidOfflineEvent : INotification
    {
        public OrderVoidOfflineEvent(Order order)
        {
            Order = order;
        }

        /// <summary>
        /// Order
        /// </summary>
        public Order Order { get; private set; }
    }
}
