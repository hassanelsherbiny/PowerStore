using PowerStore.Domain.Catalog;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Services.Queries.Models.Catalog
{
    public class GetBidsByProductIdQuery : IRequest<IList<Bid>>
    {
        public string ProductId { get; set; }
    }
}
