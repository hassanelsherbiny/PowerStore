using PowerStore.Domain.Shipping;
using PowerStore.Services.Notifications.Shipping;
using MediatR;
using System.Threading.Tasks;

namespace PowerStore.Services.Events.Extensions
{
    public static class ShippingEventPublisherExtensions
    {
        /// <summary>
        /// Publishes the shipment sent event.
        /// </summary>
        /// <param name="eventPublisher">The event publisher.</param>
        /// <param name="shipment">The shipment.</param>
        public static async Task PublishShipmentSent(this IMediator mediator, Shipment shipment)
        {
            await mediator.Publish(new ShipmentSentEvent(shipment));
        }
        /// <summary>
        /// Publishes the shipment delivered event.
        /// </summary>
        /// <param name="eventPublisher">The event publisher.</param>
        /// <param name="shipment">The shipment.</param>
        public static async Task PublishShipmentDelivered(this IMediator mediator, Shipment shipment)
        {
            await mediator.Publish(new ShipmentDeliveredEvent(shipment));
        }
    }
}