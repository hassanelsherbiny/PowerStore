using PowerStore.Domain.Orders;
using MediatR;

namespace PowerStore.Services.Notifications.Orders
{
    /// <summary>
    /// Order refunded event
    /// </summary>
    public class OrderRefundedEvent : INotification
    {
        public OrderRefundedEvent(Order order, decimal amount)
        {
            Order = order;
            Amount = amount;
        }

        /// <summary>
        /// Order
        /// </summary>
        public Order Order { get; private set; }

        /// <summary>
        /// Amount
        /// </summary>
        public decimal Amount { get; private set; }
    }
}
