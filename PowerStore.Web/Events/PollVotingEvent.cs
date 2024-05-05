using PowerStore.Domain.Polls;
using MediatR;

namespace PowerStore.Web.Events
{
    public class PollVotingEvent : INotification
    {
        public Poll Poll { get; private set; }
        public PollAnswer PollAnswer { get; private set; }
        public PollVotingEvent(Poll poll, PollAnswer pollAnswer)
        {
            Poll = poll;
            PollAnswer = pollAnswer;
        }
    }
}
