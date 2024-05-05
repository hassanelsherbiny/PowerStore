using PowerStore.Web.Models.Polls;
using MediatR;

namespace PowerStore.Web.Features.Models.Polls
{
    public class GetPollBySystemName : IRequest<PollModel>
    {
        public string SystemName { get; set; }
    }
}
