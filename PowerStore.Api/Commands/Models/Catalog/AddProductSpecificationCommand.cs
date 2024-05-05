using PowerStore.Api.DTOs.Catalog;
using MediatR;

namespace PowerStore.Api.Commands.Models.Catalog
{
    public class AddProductSpecificationCommand : IRequest<bool>
    {
        public ProductDto Product { get; set; }
        public ProductSpecificationAttributeDto Model { get; set; }
    }
}
