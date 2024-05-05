using PowerStore.Api.DTOs.Catalog;
using MediatR;

namespace PowerStore.Api.Commands.Models.Catalog
{
    public class UpdateManufacturerCommand : IRequest<ManufacturerDto>
    {
        public ManufacturerDto Model { get; set; }
    }
}
