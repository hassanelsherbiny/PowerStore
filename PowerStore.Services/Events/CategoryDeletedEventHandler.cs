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
    public class CategoryDeletedEventHandler : INotificationHandler<EntityDeleted<Category>>
    {
        private readonly IRepository<UrlRecord> _urlRecordRepository;

        public CategoryDeletedEventHandler(
            IRepository<UrlRecord> urlRecordRepository)
        {
            _urlRecordRepository = urlRecordRepository;
        }

        public async Task Handle(EntityDeleted<Category> notification, CancellationToken cancellationToken)
        {
            //delete url
            var filters = Builders<UrlRecord>.Filter;
            var filter = filters.Eq(x => x.EntityId, notification.Entity.Id);
            filter = filter & filters.Eq(x => x.EntityName, "Category");
            await _urlRecordRepository.Collection.DeleteManyAsync(filter);
        }
    }
}