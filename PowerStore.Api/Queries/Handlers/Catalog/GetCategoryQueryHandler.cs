using PowerStore.Api.DTOs.Catalog;
using PowerStore.Api.Queries.Models.Common;
using PowerStore.Domain.Data;
using MediatR;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Api.Queries.Handlers.Common
{
    public class GetCategoryQueryHandler : IRequestHandler<GetQuery<CategoryDto>, IMongoQueryable<CategoryDto>>
    {
        private readonly IMongoDBContext _mongoDBContext;

        public GetCategoryQueryHandler(IMongoDBContext mongoDBContext)
        {
            _mongoDBContext = mongoDBContext;
        }
        public Task<IMongoQueryable<CategoryDto>> Handle(GetQuery<CategoryDto> request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.Id))
                return Task.FromResult(
                    _mongoDBContext.Database()
                    .GetCollection<CategoryDto>
                    (typeof(Domain.Catalog.Category).Name)
                    .AsQueryable());
            else
                return Task.FromResult(_mongoDBContext.Database()
                    .GetCollection<CategoryDto>(typeof(Domain.Catalog.Category).Name)
                    .AsQueryable()
                    .Where(x => x.Id == request.Id));
        }
    }
}
