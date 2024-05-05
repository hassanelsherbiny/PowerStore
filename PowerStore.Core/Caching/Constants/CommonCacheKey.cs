namespace PowerStore.Core.Caching.Constants
{
    public static partial class CacheKey
    {
        #region Settings

        /// <summary>
        /// Key for caching
        /// </summary>
        public static string SETTINGS_ALL_KEY => "PowerStore.setting.all";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string SETTINGS_PATTERN_KEY => "PowerStore.setting.";

        #endregion

        #region Discounts

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : discont ID
        /// </remarks>
        public static string DISCOUNTS_BY_ID_KEY => "PowerStore.discount.id-{0}";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : show hidden records?
        /// {1} : store ident
        /// {2} : coupon code
        /// {3} : discount name
        /// </remarks>
        public static string DISCOUNTS_ALL_KEY => "PowerStore.discount.all-{0}-{1}-{2}-{3}";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string DISCOUNTS_PATTERN_KEY => "PowerStore.discount.";

        #endregion

        #region Languages & localization

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : language ID
        /// </remarks>
        public static string LANGUAGES_BY_ID_KEY => "PowerStore.language.id-{0}";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : show hidden records?
        /// </remarks>
        public static string LANGUAGES_ALL_KEY => "PowerStore.language.all-{0}";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string LANGUAGES_PATTERN_KEY => "PowerStore.language.";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : language ID
        /// </remarks>
        public static string LOCALSTRINGRESOURCES_ALL_KEY => "PowerStore.lsr.all-{0}";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : language ID
        /// {1} : resource key
        /// </remarks>
        public static string LOCALSTRINGRESOURCES_BY_RESOURCENAME_KEY => "PowerStore.lsr.{0}-{1}";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string LOCALSTRINGRESOURCES_PATTERN_KEY => "PowerStore.lsr.";

        #endregion

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : picture ID
        /// {1} : store ID
        /// {2} : target size
        /// {3} : showDefaultPicture
        /// {4} : storeLocation
        /// {5} : pictureType
        /// </remarks>
        public static string PICTURE_BY_KEY => "PowerStore.picture-{0}-{1}-{2}-{3}-{4}-{5}";

        #region Seo

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : entity ID
        /// {1} : entity name
        /// {2} : language ID
        /// </remarks>
        public static string URLRECORD_ACTIVE_BY_ID_NAME_LANGUAGE_KEY => "PowerStore.urlrecord.active.id-name-language-{0}-{1}-{2}";

        /// <summary>
        /// Key for caching
        /// </summary>
        public static string URLRECORD_ALL_KEY => "PowerStore.urlrecord.all";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : slug
        /// </remarks>
        public static string URLRECORD_BY_SLUG_KEY => "PowerStore.urlrecord.active.slug-{0}";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string URLRECORD_PATTERN_KEY = "PowerStore.urlrecord.";

        #endregion

        #region Stores

        /// <summary>
        /// Key for caching
        /// </summary>
        public static string STORES_ALL_KEY => "PowerStore.stores.all";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : store ID
        /// </remarks>
        public static string STORES_BY_ID_KEY => "PowerStore.stores.id-{0}";

        #endregion

        #region Tax

        /// <summary>
        /// Key for caching
        /// </summary>
        public static string TAXCATEGORIES_ALL_KEY => "PowerStore.taxcategory.all";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : tax category ID
        /// </remarks>
        public static string TAXCATEGORIES_BY_ID_KEY => "PowerStore.taxcategory.id-{0}";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string TAXCATEGORIES_PATTERN_KEY => "PowerStore.taxcategory.";

        #endregion

        #region Topics

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : store ID
        /// {1} : ignore ACL?
        /// </remarks>
        public static string TOPICS_ALL_KEY => "PowerStore.topics.all-{0}-{1}";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : topic ID
        /// </remarks>
        public static string TOPICS_BY_ID_KEY => "PowerStore.topics.id-{0}";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : topic systemname
        /// {1} : store id
        /// </remarks>
        public static string TOPICS_BY_SYSTEMNAME => "PowerStore.topics.systemname-{0}-{1}";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string TOPICS_PATTERN_KEY => "PowerStore.topics.";

        #endregion
    }
}
