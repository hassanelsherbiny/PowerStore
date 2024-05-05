using MediatR;

namespace PowerStore.Web.Features.Models.Catalog
{
    public class GetCategoryTemplateViewPath : IRequest<string>
    {
        public string TemplateId { get; set; }
    }
}
