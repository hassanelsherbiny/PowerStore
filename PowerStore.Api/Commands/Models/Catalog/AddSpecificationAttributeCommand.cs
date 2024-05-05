using PowerStore.Api.DTOs.Catalog;
using MediatR;

namespace PowerStore.Api.Commands.Models.Catalog
{
    public class AddSpecificationAttributeCommand : IRequest<SpecificationAttributeDto>
    {
        public SpecificationAttributeDto Model { get; set; }
    }
}
