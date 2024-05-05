using PowerStore.Api.DTOs.Catalog;
using MediatR;

namespace PowerStore.Api.Commands.Models.Catalog
{
    public class UpdateCategoryCommand : IRequest<CategoryDto>
    {
        public CategoryDto Model { get; set; }
    }
}
