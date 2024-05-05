using PowerStore.Core.Caching;
using PowerStore.Domain.Orders;
using PowerStore.Core.Events;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Infrastructure.Cache
{
    public class ReturnRequestActionNotificatioHandler :
        INotificationHandler<EntityInserted<ReturnRequestAction>>,
        INotificationHandler<EntityUpdated<ReturnRequestAction>>,
        INotificationHandler<EntityDeleted<ReturnRequestAction>>
    {

        private readonly ICacheBase _cacheBase;

        public ReturnRequestActionNotificatioHandler(ICacheBase cacheManager)
        {
            _cacheBase = cacheManager;
        }

        public async Task Handle(EntityInserted<ReturnRequestAction> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheBase.RemoveByPrefix(ModelCacheEventConst.RETURNREQUESTACTIONS_PATTERN_KEY);
        }
        public async Task Handle(EntityUpdated<ReturnRequestAction> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheBase.RemoveByPrefix(ModelCacheEventConst.RETURNREQUESTACTIONS_PATTERN_KEY);
        }
        public async Task Handle(EntityDeleted<ReturnRequestAction> eventMessage, CancellationToken cancellationToken)
        {
            await _cacheBase.RemoveByPrefix(ModelCacheEventConst.RETURNREQUESTACTIONS_PATTERN_KEY);
        }
    }
}