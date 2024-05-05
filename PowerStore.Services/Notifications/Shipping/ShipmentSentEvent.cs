using PowerStore.Domain.Shipping;
using MediatR;

namespace PowerStore.Services.Notifications.Shipping
{
    /// <summary>
    /// Shipment sent event
    /// </summary>
    public class ShipmentSentEvent : INotification
    {
        public ShipmentSentEvent(Shipment shipment)
        {
            Shipment = shipment;
        }

        /// <summary>
        /// Shipment
        /// </summary>
        public Shipment Shipment { get; private set; }
    }
}
