using PowerStore.Core.Caching;
using PowerStore.Domain.Catalog;
using PowerStore.Core.Events;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Infrastructure.Cache
{
    public class ProductTagNotificatioHandler :
        INotificationHandler<EntityInserted<ProductTag>>,
        INotificationHandler<EntityUpdated<ProductTag>>,
        INotificationHandler<EntityDeleted<ProductTag>>
    {

        private readonly ICacheBase _cacheBase;

        public ProductTagNotificatioHandler(ICacheBase cacheManager)
        {
            _cacheBase = cacheManager;
        }
        public async Task Handle(EntityInserted<ProductTag> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheBase.RemoveByPrefix(ModelCacheEventConst.PRODUCTTAG_POPULAR_PATTERN_KEY);
            await _cacheBase.RemoveByPrefix(ModelCacheEventConst.PRODUCTTAG_BY_PRODUCT_PATTERN_KEY);
        }
        public async Task Handle(EntityUpdated<ProductTag> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheBase.RemoveByPrefix(ModelCacheEventConst.PRODUCTTAG_POPULAR_PATTERN_KEY);
            await _cacheBase.RemoveByPrefix(ModelCacheEventConst.PRODUCTTAG_BY_PRODUCT_PATTERN_KEY);
        }
        public async Task Handle(EntityDeleted<ProductTag> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheBase.RemoveByPrefix(ModelCacheEventConst.PRODUCTTAG_POPULAR_PATTERN_KEY);
            await _cacheBase.RemoveByPrefix(ModelCacheEventConst.PRODUCTTAG_BY_PRODUCT_PATTERN_KEY);
        }
    }
}