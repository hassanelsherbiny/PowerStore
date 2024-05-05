using PowerStore.Domain.Orders;
using PowerStore.Domain.Vendors;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Services.Queries.Models.Orders
{
    public class GetVendorsInOrderQuery : IRequest<IList<Vendor>>
    {
        public Order Order { get; set; }
    }
}
