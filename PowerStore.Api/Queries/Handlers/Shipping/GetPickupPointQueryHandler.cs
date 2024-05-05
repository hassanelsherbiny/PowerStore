using PowerStore.Api.DTOs.Shipping;
using PowerStore.Api.Queries.Models.Common;
using PowerStore.Domain.Data;
using MediatR;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Api.Queries.Handlers.Shipping
{
    public class GetPickupPointQueryHandler : IRequestHandler<GetQuery<PickupPointDto>, IMongoQueryable<PickupPointDto>>
    {
        private readonly IMongoDBContext _mongoDBContext;

        public GetPickupPointQueryHandler(IMongoDBContext mongoDBContext)
        {
            _mongoDBContext = mongoDBContext;
        }
        public Task<IMongoQueryable<PickupPointDto>> Handle(GetQuery<PickupPointDto> request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.Id))
                return Task.FromResult
                    (_mongoDBContext.Database()
                    .GetCollection<PickupPointDto>
                    (typeof(Domain.Shipping.PickupPoint).Name)
                    .AsQueryable());
            else
                return Task.FromResult
                    (_mongoDBContext.Database()
                    .GetCollection<PickupPointDto>
                    (typeof(Domain.Shipping.PickupPoint).Name)
                    .AsQueryable()
                    .Where(x => x.Id == request.Id));
        }
    }
}