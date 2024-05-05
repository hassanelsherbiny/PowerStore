using PowerStore.Domain.Catalog;
using MediatR;

namespace PowerStore.Web.Features.Models.Catalog
{
    public class GetProductAttribute : IRequest<ProductAttribute>
    {
        public string Id { get; set; }
    }
}
