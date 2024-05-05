using PowerStore.Web.Models.Topics;
using MediatR;

namespace PowerStore.Web.Features.Models.Topics
{
    public class GetTopicBlock : IRequest<TopicModel>
    {
        public string SystemName { get; set; }
        public string TopicId { get; set; }
        public string Password { get; set; } 
    }
}
