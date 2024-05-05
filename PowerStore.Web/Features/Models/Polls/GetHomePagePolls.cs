using PowerStore.Web.Models.Polls;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Polls
{
    public class GetHomePagePolls : IRequest<IList<PollModel>>
    {
    }
}
