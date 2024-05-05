using PowerStore.Domain.Catalog;
using PowerStore.Domain.Data;
using PowerStore.Services.Queries.Models.Catalog;
using MediatR;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Services.Queries.Handlers.Catalog
{
    public class GetBidsByProductIdQueryHandler : IRequestHandler<GetBidsByProductIdQuery, IList<Bid>>
    {
        private readonly IRepository<Bid> _bidRepository;

        public GetBidsByProductIdQueryHandler(IRepository<Bid> bidRepository)
        {
            _bidRepository = bidRepository;
        }

        public async Task<IList<Bid>> Handle(GetBidsByProductIdQuery request, CancellationToken cancellationToken)
        {
            return await _bidRepository
                .Table.Where(x => x.ProductId == request.ProductId)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}
