using PowerStore.Api.DTOs.Catalog;
using MediatR;

namespace PowerStore.Api.Commands.Models.Catalog
{
    public class UpdateProductCommand : IRequest<ProductDto>
    {
        public ProductDto Model { get; set; }
    }
}
