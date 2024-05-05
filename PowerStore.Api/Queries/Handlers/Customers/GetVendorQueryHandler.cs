using PowerStore.Api.DTOs.Customers;
using PowerStore.Api.Queries.Models.Common;
using PowerStore.Domain.Data;
using MediatR;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Api.Queries.Handlers.Customers
{
    public class GetVendorQueryHandler : IRequestHandler<GetQuery<VendorDto>, IMongoQueryable<VendorDto>>
    {
        private readonly IMongoDBContext _mongoDBContext;

        public GetVendorQueryHandler(IMongoDBContext mongoDBContext)
        {
            _mongoDBContext = mongoDBContext;
        }
        public Task<IMongoQueryable<VendorDto>> Handle(GetQuery<VendorDto> request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.Id))
                return Task.FromResult(
                    _mongoDBContext.Database()
                    .GetCollection<VendorDto>
                    (typeof(Domain.Vendors.Vendor).Name)
                    .AsQueryable());
            else
                return Task.FromResult(_mongoDBContext.Database()
                    .GetCollection<VendorDto>(typeof(Domain.Vendors.Vendor).Name)
                    .AsQueryable()
                    .Where(x => x.Id == request.Id));
        }
    }
}
