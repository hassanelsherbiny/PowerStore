using PowerStore.Api.DTOs.Catalog;
using MediatR;

namespace PowerStore.Api.Commands.Models.Catalog
{
    public class DeleteCategoryCommand : IRequest<bool>
    {
        public CategoryDto Model { get; set; }
    }
}
