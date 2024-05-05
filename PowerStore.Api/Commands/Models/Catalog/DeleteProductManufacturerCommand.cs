using PowerStore.Api.DTOs.Catalog;
using MediatR;

namespace PowerStore.Api.Commands.Models.Catalog
{
    public class DeleteProductManufacturerCommand : IRequest<bool>
    {
        public ProductDto Product { get; set; }
        public string ManufacturerId { get; set; }
    }
}
