using PowerStore.Api.DTOs.Catalog;
using MediatR;

namespace PowerStore.Api.Commands.Models.Catalog
{
    public class DeleteProductAttributeMappingCommand : IRequest<bool>
    {
        public ProductDto Product { get; set; }
        public ProductAttributeMappingDto Model { get; set; }
    }
}
