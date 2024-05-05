using PowerStore.Domain.Customers;
using PowerStore.Services.Customers;
using PowerStore.Services.Notifications.Orders;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Services.Events
{
    public class OrderPlacedEventHandler : INotificationHandler<OrderPlacedEvent>
    {
        private readonly ICustomerActionEventService _customerActionEventService;

        public OrderPlacedEventHandler(ICustomerActionEventService customerActionEventService)
        {
            _customerActionEventService = customerActionEventService;
        }

        public async Task Handle(OrderPlacedEvent notification, CancellationToken cancellationToken)
        {
            //cutomer action - add order
            await _customerActionEventService.AddOrder(notification.Order, CustomerActionTypeEnum.AddOrder);
        }
    }
}
