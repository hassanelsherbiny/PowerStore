using PowerStore.Api.DTOs.Catalog;
using MediatR;

namespace PowerStore.Api.Commands.Models.Catalog
{
    public class DeleteProductAttributeCommand : IRequest<bool>
    {
        public ProductAttributeDto Model { get; set; }
    }
}
