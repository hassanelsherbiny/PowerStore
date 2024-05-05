using System.Threading.Tasks;

namespace PowerStore.Core.Caching.Message
{
    public interface IMessageBus : IMessagePublisher, IMessageSubscriber
    {
        Task OnSubscriptionChanged(IMessageEvent message);
    }
}
