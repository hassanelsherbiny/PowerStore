namespace PowerStore.Core.Caching.Constants
{
    public static partial class CacheKey
    {
        #region Contact attributes

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : store ID
        /// {1} : ignore ACL?
        /// </remarks>
        public static string CONTACTATTRIBUTES_ALL_KEY => "PowerStore.contactattribute.all-{0}-{1}";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : contact attribute ID
        /// </remarks>
        public static string CONTACTATTRIBUTES_BY_ID_KEY => "PowerStore.contactattribute.id-{0}";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string CONTACTATTRIBUTES_PATTERN_KEY => "PowerStore.contactattribute.";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string CONTACTATTRIBUTEVALUES_PATTERN_KEY => "PowerStore.contactattributevalue.";

        #endregion

        #region Email account

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : email account ID
        /// </remarks>
        public static string EMAILACCOUNT_BY_ID_KEY =>"PowerStore.emailaccount.id-{0}";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// </remarks>
        public static string EMAILACCOUNT_ALL_KEY => "PowerStore.emailaccount.all";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string EMAILACCOUNT_PATTERN_KEY => "PowerStore.emailaccount.";

        #endregion

        #region Message template

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : store ID
        /// </remarks>
        public static string MESSAGETEMPLATES_ALL_KEY => "PowerStore.messagetemplate.all-{0}";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : template name
        /// {1} : store ID
        /// </remarks>
        public static string MESSAGETEMPLATES_BY_NAME_KEY => "PowerStore.messagetemplate.name-{0}-{1}";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string MESSAGETEMPLATES_PATTERN_KEY => "PowerStore.messagetemplate.";

        #endregion
    }
}
