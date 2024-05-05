using PowerStore.Domain.Data;
using PowerStore.Domain.Catalog;
using PowerStore.Services.Queries.Models.Catalog;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Services.Queries.Handlers.Catalog
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IRepository<Product> _productRepository;

        public GetProductByIdQueryHandler(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.Id))
                return Task.FromResult<Product>(null);

            return _productRepository.GetByIdAsync(request.Id);
        }
    }
}
