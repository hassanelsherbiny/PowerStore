using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using PowerStore.Core.Caching.Message;
using PowerStore.Core.Configuration;
using System.Diagnostics;

namespace PowerStore.Core.Caching.Redis
{
    public class RedisMessageBus : IMessageBus
    {
        private readonly ISubscriber _subscriber;
        private readonly IServiceProvider _serviceProvider;
        private readonly PowerStoreConfig _PowerStoreConfig;

        private static readonly string _clientId = Guid.NewGuid().ToString("N");

        public RedisMessageBus(ISubscriber subscriber, IServiceProvider serviceProvider, PowerStoreConfig PowerStoreConfig)
        {
            _subscriber = subscriber;
            _serviceProvider = serviceProvider;
            _PowerStoreConfig = PowerStoreConfig;
            SubscribeAsync();
        }

        public async Task PublishAsync<TMessage>(TMessage msg) where TMessage : IMessageEvent
        {
            try
            {
                var pub = _subscriber.Multiplexer.GetSubscriber();
                var clientmsg = new MessageEventClient {
                    ClientId = _clientId,
                    Key = msg.Key,
                    MessageType = msg.MessageType
                };
                var message = JsonConvert.SerializeObject(clientmsg);
                await pub.PublishAsync(_PowerStoreConfig.RedisPubSubChannel, message);
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public virtual Task SubscribeAsync()
        {
            var sub = _subscriber.Multiplexer.GetSubscriber();

            sub.SubscribeAsync(_PowerStoreConfig.RedisPubSubChannel, async (_, redisValue) =>
            {
                try
                {
                    var message = JsonConvert.DeserializeObject<MessageEventClient>(redisValue);
                    if (message != null && message.ClientId != _clientId)
                        await OnSubscriptionChanged(message);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            });
            return Task.CompletedTask;
        }

        public async Task OnSubscriptionChanged(IMessageEvent message)
        {
            using (var scope = _serviceProvider.CreateScope())
            {
                var cache = scope.ServiceProvider.GetRequiredService<ICacheBase>();
                switch (message.MessageType)
                {
                    case (int)MessageEventType.RemoveKey:
                        await cache.RemoveAsync(message.Key, false);
                        break;
                    case (int)MessageEventType.RemoveByPrefix:
                        await cache.RemoveByPrefix(message.Key, false);
                        break;
                    case (int)MessageEventType.ClearCache:
                        await cache.Clear(false);
                        break;
                }

            }
        }
    }
}
