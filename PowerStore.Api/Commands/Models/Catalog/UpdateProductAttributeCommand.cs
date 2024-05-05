using PowerStore.Api.DTOs.Catalog;
using MediatR;

namespace PowerStore.Api.Commands.Models.Catalog
{
    public class UpdateProductAttributeCommand : IRequest<ProductAttributeDto>
    {
        public ProductAttributeDto Model { get; set; }
    }
}
