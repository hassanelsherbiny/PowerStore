using PowerStore.Api.DTOs.Catalog;
using MediatR;

namespace PowerStore.Api.Commands.Models.Catalog
{
    public class DeleteManufacturerCommand : IRequest<bool>
    {
        public ManufacturerDto Model { get; set; }
    }
}
