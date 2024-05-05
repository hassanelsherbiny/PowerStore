using PowerStore.Core.Caching;
using PowerStore.Domain.Data;
using PowerStore.Domain.Catalog;
using PowerStore.Domain.Customers;
using PowerStore.Services.Catalog;
using PowerStore.Services.Queries.Models.Catalog;
using MediatR;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using PowerStore.Core.Caching.Constants;

namespace PowerStore.Services.Queries.Handlers.Catalog
{
    public class GetPersonalizedProductsQueryHandler : IRequestHandler<GetPersonalizedProductsQuery, IList<Product>>
    {
        
        private readonly IProductService _productService;
        private readonly ICacheBase _cacheBase;
        private readonly IRepository<CustomerProduct> _customerProductRepository;

        public GetPersonalizedProductsQueryHandler(
            IProductService productService,
            ICacheBase cacheManager,
            IRepository<CustomerProduct> customerProductRepository)
        {
            _productService = productService;
            _cacheBase = cacheManager;
            _customerProductRepository = customerProductRepository;
        }

        public async Task<IList<Product>> Handle(GetPersonalizedProductsQuery request, CancellationToken cancellationToken)
        {
            return await _cacheBase.GetAsync(string.Format(CacheKey.PRODUCTS_CUSTOMER_PERSONAL_KEY, request.CustomerId), async () =>
            {
                var query = from cr in _customerProductRepository.Table
                            where cr.CustomerId == request.CustomerId
                            orderby cr.DisplayOrder
                            select cr.ProductId;

                var productIds = await query.Take(request.ProductsNumber).ToListAsync();

                var products = new List<Product>();
                var ids = await _productService.GetProductsByIds(productIds.Distinct().ToArray());
                foreach (var product in ids)
                    if (product.Published)
                        products.Add(product);

                return products;
            });

        }
    }
}
