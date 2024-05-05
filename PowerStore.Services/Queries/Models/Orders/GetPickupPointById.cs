using PowerStore.Domain.Shipping;
using MediatR;

namespace PowerStore.Services.Queries.Models.Orders
{
    public class GetPickupPointById : IRequest<PickupPoint>
    {
        public string Id { get; set; }
    }
}
