using PowerStore.Domain.Data;
using PowerStore.Domain.Vendors;
using PowerStore.Services.Queries.Models.Customers;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Services.Queries.Handlers.Customers
{
    public class GetVendorByIdQueryHandler : IRequestHandler<GetVendorByIdQuery, Vendor>
    {
        private readonly IRepository<Vendor> _vendorRepository;

        public GetVendorByIdQueryHandler(IRepository<Vendor> vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }

        public Task<Vendor> Handle(GetVendorByIdQuery request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.Id))
                return Task.FromResult<Vendor>(null);

            return _vendorRepository.GetByIdAsync(request.Id);
        }
    }
}
