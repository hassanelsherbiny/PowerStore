using PowerStore.Domain.Data;
using PowerStore.Domain.Catalog;
using PowerStore.Domain.Shipping;
using PowerStore.Core.Events;
using MediatR;
using MongoDB.Driver;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Services.Events
{
    public class DeliveryDateDeletedEventHandler : INotificationHandler<EntityDeleted<DeliveryDate>>
    {
        private readonly IRepository<Product> _productRepository;

        public DeliveryDateDeletedEventHandler(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task Handle(EntityDeleted<DeliveryDate> notification, CancellationToken cancellationToken)
        {
            var builder = Builders<Product>.Filter;
            var filter = builder.Eq(x => x.DeliveryDateId, notification.Entity.Id);
            var update = Builders<Product>.Update
                .Set(x => x.DeliveryDateId, "");

            await _productRepository.Collection.UpdateManyAsync(filter, update);
        }
    }
}
