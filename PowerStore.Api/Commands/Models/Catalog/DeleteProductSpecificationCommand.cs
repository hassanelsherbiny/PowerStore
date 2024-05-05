using PowerStore.Api.DTOs.Catalog;
using MediatR;

namespace PowerStore.Api.Commands.Models.Catalog
{
    public class DeleteProductSpecificationCommand : IRequest<bool>
    {
        public ProductDto Product { get; set; }
        public string Id { get; set; }
    }
}
