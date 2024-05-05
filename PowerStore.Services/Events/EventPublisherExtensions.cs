using PowerStore.Core.Events;
using PowerStore.Domain;
using MediatR;
using System.Threading.Tasks;

namespace PowerStore.Services.Events
{
    public static class EventPublisherExtensions
    {
        public static async Task EntityInserted<T>(this IMediator eventPublisher, T entity) where T : ParentEntity
        {
            await eventPublisher.Publish(new EntityInserted<T>(entity));
        }

        public static async Task EntityUpdated<T>(this IMediator eventPublisher, T entity) where T : ParentEntity
        {
            await eventPublisher.Publish(new EntityUpdated<T>(entity));
        }

        public static async Task EntityDeleted<T>(this IMediator eventPublisher, T entity) where T : ParentEntity
        {
            await eventPublisher.Publish(new EntityDeleted<T>(entity));
        }

    }
}