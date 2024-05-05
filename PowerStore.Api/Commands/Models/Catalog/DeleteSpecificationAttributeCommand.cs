using PowerStore.Api.DTOs.Catalog;
using MediatR;

namespace PowerStore.Api.Commands.Models.Catalog
{
    public class DeleteSpecificationAttributeCommand : IRequest<bool>
    {
        public SpecificationAttributeDto Model { get; set; }
    }
}
