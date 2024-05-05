using PowerStore.Domain.Orders;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Services.Commands.Models.Orders
{
    public class ReOrderCommand : IRequest<IList<string>>
    {
        public Order Order { get; set; }
    }
}
