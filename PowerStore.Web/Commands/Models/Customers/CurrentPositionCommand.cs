using PowerStore.Domain.Customers;
using PowerStore.Web.Models.Common;
using MediatR;

namespace PowerStore.Web.Commands.Models.Customers
{
    public class CurrentPositionCommand : IRequest<bool>
    {
        public Customer Customer { get; set; }
        public LocationModel Model { get; set; }
    }
}
