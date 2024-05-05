using PowerStore.Domain.Catalog;
using PowerStore.Domain.Localization;
using PowerStore.Web.Models.Catalog;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Products
{
    public class GetProductSpecification : IRequest<IList<ProductSpecificationModel>>
    {
        public Product Product { get; set; }
        public Language Language { get; set; }

    }
}
