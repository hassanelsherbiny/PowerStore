using PowerStore.Domain.Data;
using PowerStore.Domain.Catalog;
using PowerStore.Domain.Seo;
using PowerStore.Core.Events;
using MediatR;
using MongoDB.Driver;
using System.Threading;
using System.Threading.Tasks;


namespace PowerStore.Services.Events
{
    public class ManufacturerDeletedEventHandler : INotificationHandler<EntityDeleted<Manufacturer>>
    {
        private readonly IRepository<UrlRecord> _urlRecordRepository;

        public ManufacturerDeletedEventHandler(
            IRepository<UrlRecord> urlRecordRepository)
        {
            _urlRecordRepository = urlRecordRepository;
        }

        public async Task Handle(EntityDeleted<Manufacturer> notification, CancellationToken cancellationToken)
        {
            //delete url
            var filters = Builders<UrlRecord>.Filter;
            var filter = filters.Eq(x => x.EntityId, notification.Entity.Id);
            filter = filter & filters.Eq(x => x.EntityName, "Manufacturer");
            await _urlRecordRepository.Collection.DeleteManyAsync(filter);
        }
    }
}