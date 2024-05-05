using PowerStore.Core.Caching;
using PowerStore.Domain.Discounts;
using PowerStore.Core.Events;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Services.Discounts.Cache
{
    /// <summary>
    /// Cache event consumer (used for caching of discount requirements)
    /// </summary>
    public abstract class DiscountRequirementEventConsumer :
        //discounts
        INotificationHandler<EntityUpdated<Discount>>,
        INotificationHandler<EntityDeleted<Discount>>

    {
        /// <summary>
        /// Key for discount requirement of a certain discount
        /// </summary>
        /// <remarks>
        /// {0} : discount id
        /// </remarks>
        public const string DISCOUNT_REQUIREMENT_MODEL_KEY = "PowerStore.discountrequirements.all-{0}";
        public const string DISCOUNT_REQUIREMENT_PATTERN_KEY = "PowerStore.discountrequirements";

        private readonly ICacheBase _cacheBase;

        public DiscountRequirementEventConsumer(ICacheBase cacheManager)
        {
            _cacheBase = cacheManager;
        }

        public async Task Handle(EntityUpdated<Discount> notification, CancellationToken cancellationToken)
        {
            await _cacheBase.RemoveByPrefix(DISCOUNT_REQUIREMENT_PATTERN_KEY);
        }

        public async Task Handle(EntityDeleted<Discount> notification, CancellationToken cancellationToken)
        {
            await _cacheBase.RemoveByPrefix(DISCOUNT_REQUIREMENT_PATTERN_KEY);
        }

    }
}
