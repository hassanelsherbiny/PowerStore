using PowerStore.Api.DTOs.Catalog;
using MediatR;

namespace PowerStore.Api.Commands.Models.Catalog
{
    public class AddManufacturerCommand : IRequest<ManufacturerDto>
    {
        public ManufacturerDto Model { get; set; }
    }
}
