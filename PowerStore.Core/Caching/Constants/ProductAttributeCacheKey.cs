namespace PowerStore.Core.Caching.Constants
{
    public static partial class CacheKey
    {
        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : page index
        /// {1} : page size
        /// </remarks>
        public static string PRODUCTATTRIBUTES_ALL_KEY => "PowerStore.productattribute.all-{0}-{1}";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : product attribute ID
        /// </remarks>
        public static string PRODUCTATTRIBUTES_BY_ID_KEY => "PowerStore.productattribute.id-{0}";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string PRODUCTATTRIBUTES_PATTERN_KEY => "PowerStore.productattribute.";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string PRODUCTATTRIBUTEMAPPINGS_PATTERN_KEY => "PowerStore.productattributemapping.";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string PRODUCTATTRIBUTEVALUES_PATTERN_KEY => "PowerStore.productattributevalue.";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string PRODUCTATTRIBUTECOMBINATIONS_PATTERN_KEY => "PowerStore.productattributecombination.";

    }
}
