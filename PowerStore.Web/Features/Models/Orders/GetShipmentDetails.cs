using PowerStore.Domain.Customers;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Orders;
using PowerStore.Domain.Shipping;
using PowerStore.Web.Models.Orders;
using MediatR;

namespace PowerStore.Web.Features.Models.Orders
{
    public class GetShipmentDetails : IRequest<ShipmentDetailsModel>
    {
        public Shipment Shipment { get; set; }
        public Order Order { get; set; }
        public Customer Customer { get; set; }
        public Language Language { get; set; }
    }
}
