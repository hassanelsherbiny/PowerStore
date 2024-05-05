using MediatR;

namespace PowerStore.Web.Features.Models.Topics
{
    public class GetTopicTemplateViewPath : IRequest<string>
    {
        public string TemplateId { get; set; }
    }
}
