using System.Threading.Tasks;

namespace PowerStore.Core.Caching.Message
{
    public interface IMessageSubscriber
    {
        Task SubscribeAsync();
    }
}
