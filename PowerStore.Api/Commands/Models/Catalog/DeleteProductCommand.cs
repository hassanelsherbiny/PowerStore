using PowerStore.Api.DTOs.Catalog;
using MediatR;

namespace PowerStore.Api.Commands.Models.Catalog
{
    public class DeleteProductCommand : IRequest<bool>
    {
        public ProductDto Model { get; set; }
    }
}
