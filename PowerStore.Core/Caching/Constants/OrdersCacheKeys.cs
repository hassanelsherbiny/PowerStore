namespace PowerStore.Core.Caching.Constants
{
    public static partial class CacheKey
    {
        #region Checkout attributes

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : store ID
        /// {1} : >A value indicating whether we should exlude shippable attributes
        /// {2} : ignore ACL?
        /// </remarks>
        public static string CHECKOUTATTRIBUTES_ALL_KEY => "PowerStore.checkoutattribute.all-{0}-{1}-{2}";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : checkout attribute ID
        /// </remarks>
        public static string CHECKOUTATTRIBUTES_BY_ID_KEY => "PowerStore.checkoutattribute.id-{0}";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string CHECKOUTATTRIBUTES_PATTERN_KEY => "PowerStore.checkoutattribute.";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string CHECKOUTATTRIBUTEVALUES_PATTERN_KEY => "PowerStore.checkoutattributevalue.";

        #endregion

        #region Order tags

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : store ID
        /// </remarks>
        public static string ORDERTAG_COUNT_KEY => "PowerStore.ordertag.count-{0}";

        /// <summary>
        /// Key for all tags
        /// </summary>
        public static string ORDERTAG_ALL_KEY => "PowerStore.ordertag.all";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string ORDERTAG_PATTERN_KEY => "PowerStore.ordertag.";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : order ID
        /// </remarks>
        public static string ORDERS_BY_ID_KEY => "PowerStore.order.id-{0}";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>        
        public static string ORDERS_PATTERN_KEY => "PowerStore.order.";

        #endregion

    }
}
