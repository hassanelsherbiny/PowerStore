using PowerStore.Domain.Catalog;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Services.Queries.Models.Catalog
{
    public class GetRecommendedProductsQuery : IRequest<IList<Product>>
    {
        public string[] CustomerRoleIds { get; set; }
        public string StoreId { get; set; }
    }
}
