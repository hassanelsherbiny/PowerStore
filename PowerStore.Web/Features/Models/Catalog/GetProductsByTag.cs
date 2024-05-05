using PowerStore.Domain.Catalog;
using PowerStore.Domain.Customers;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Catalog;
using MediatR;

namespace PowerStore.Web.Features.Models.Catalog
{
    public class GetProductsByTag : IRequest<ProductsByTagModel>
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public Language Language { get; set; }
        public ProductTag ProductTag { get; set; }
        public CatalogPagingFilteringModel Command { get; set; }
    }
}
