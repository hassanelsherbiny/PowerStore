using PowerStore.Core.Caching;
using PowerStore.Domain.Catalog;
using PowerStore.Core.Events;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Infrastructure.Cache
{
    public class SimilarProductNotificatioHandler :
        INotificationHandler<EntityInserted<SimilarProduct>>,
        INotificationHandler<EntityUpdated<SimilarProduct>>,
        INotificationHandler<EntityDeleted<SimilarProduct>>
    {

        private readonly ICacheBase _cacheBase;

        public SimilarProductNotificatioHandler(ICacheBase cacheManager)
        {
            _cacheBase = cacheManager;
        }

        public async Task Handle(EntityInserted<SimilarProduct> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheBase.RemoveByPrefix(string.Format(ModelCacheEventConst.PRODUCTS_SIMILAR_IDS_PATTERN_KEY, eventMessage.Entity.ProductId1));
            await _cacheBase.RemoveByPrefix(string.Format(ModelCacheEventConst.PRODUCTS_SIMILAR_IDS_PATTERN_KEY, eventMessage.Entity.ProductId2));
        }
        public async Task Handle(EntityUpdated<SimilarProduct> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheBase.RemoveByPrefix(string.Format(ModelCacheEventConst.PRODUCTS_SIMILAR_IDS_PATTERN_KEY, eventMessage.Entity.ProductId1));
            await _cacheBase.RemoveByPrefix(string.Format(ModelCacheEventConst.PRODUCTS_SIMILAR_IDS_PATTERN_KEY, eventMessage.Entity.ProductId2));
        }
        public async Task Handle(EntityDeleted<SimilarProduct> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheBase.RemoveByPrefix(string.Format(ModelCacheEventConst.PRODUCTS_SIMILAR_IDS_PATTERN_KEY, eventMessage.Entity.ProductId1));
            await _cacheBase.RemoveByPrefix(string.Format(ModelCacheEventConst.PRODUCTS_SIMILAR_IDS_PATTERN_KEY, eventMessage.Entity.ProductId2));
        }
    }
}