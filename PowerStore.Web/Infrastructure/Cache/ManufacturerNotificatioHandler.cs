using PowerStore.Core.Caching;
using PowerStore.Domain.Catalog;
using PowerStore.Core.Events;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Infrastructure.Cache
{
    public class ManufacturerNotificatioHandler :
        INotificationHandler<EntityInserted<Manufacturer>>,
        INotificationHandler<EntityUpdated<Manufacturer>>,
        INotificationHandler<EntityDeleted<Manufacturer>>
    {

        private readonly ICacheBase _cacheBase;

        public ManufacturerNotificatioHandler(ICacheBase cacheManager)
        {
            _cacheBase = cacheManager;
        }

        public async Task Handle(EntityInserted<Manufacturer> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheBase.RemoveByPrefix(ModelCacheEventConst.MANUFACTURER_NAVIGATION_PATTERN_KEY);
            await _cacheBase.RemoveByPrefix(ModelCacheEventConst.SITEMAP_PATTERN_KEY);
        }
        public async Task Handle(EntityUpdated<Manufacturer> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheBase.RemoveByPrefix(ModelCacheEventConst.MANUFACTURER_NAVIGATION_PATTERN_KEY);
            await _cacheBase.RemoveByPrefix(ModelCacheEventConst.PRODUCT_MANUFACTURERS_PATTERN_KEY);
            await _cacheBase.RemoveByPrefix(ModelCacheEventConst.SITEMAP_PATTERN_KEY);
        }
        public async Task Handle(EntityDeleted<Manufacturer> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheBase.RemoveByPrefix(ModelCacheEventConst.MANUFACTURER_NAVIGATION_PATTERN_KEY);
            await _cacheBase.RemoveByPrefix(ModelCacheEventConst.PRODUCT_MANUFACTURERS_PATTERN_KEY);
            await _cacheBase.RemoveByPrefix(ModelCacheEventConst.SITEMAP_PATTERN_KEY);
        }
    }
}
