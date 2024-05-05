using PowerStore.Api.DTOs.Catalog;
using MediatR;

namespace PowerStore.Api.Commands.Models.Catalog
{
    public class AddProductCommand : IRequest<ProductDto>
    {
        public ProductDto Model { get; set; }
    }
}
