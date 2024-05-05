namespace PowerStore.Core.Caching.Constants
{
    public static partial class CacheKey
    {
        public static string CUSTOMER_ACTION_TYPE => "PowerStore.customer.action.type";

        /// <summary>
        /// Key for caching
        /// </summary>
        public static string CUSTOMERATTRIBUTES_ALL_KEY => "PowerStore.customerattribute.all";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : customer attribute ID
        /// </remarks>
        public static string CUSTOMERATTRIBUTES_BY_ID_KEY => "PowerStore.customerattribute.id-{0}";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string CUSTOMERATTRIBUTES_PATTERN_KEY => "PowerStore.customerattribute.";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string CUSTOMERATTRIBUTEVALUES_PATTERN_KEY => "PowerStore.customerattributevalue.";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : ident
        /// </remarks>
        public static string CUSTOMERROLES_BY_KEY => "PowerStore.customerrole.key-{0}";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : system name
        /// </remarks>
        public static string CUSTOMERROLES_BY_SYSTEMNAME_KEY => "PowerStore.customerrole.systemname-{0}";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string CUSTOMERROLES_PATTERN_KEY => "PowerStore.customerrole.";

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : customer role Id?
        /// </remarks>
        public static string CUSTOMERROLESPRODUCTS_ROLE_KEY => "PowerStore.customerroleproducts.role-{0}";

        #region Customer activity

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : ident
        /// </remarks>
        public static string ACTIVITYTYPE_BY_KEY => "PowerStore.activitytype.id-{0}";

        /// <summary>
        /// Key for caching
        /// </summary>
        public static string ACTIVITYTYPE_ALL_KEY => "PowerStore.activitytype.all";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string ACTIVITYTYPE_PATTERN_KEY => "PowerStore.activitytype.";

        #endregion

        #region Sales person

        /// <summary>
        /// Key for caching
        /// </summary>
        /// <remarks>
        /// {0} : salesemployee ID
        /// </remarks>
        public static string SALESEMPLOYEE_BY_ID_KEY => "PowerStore.salesemployee.id-{0}";

        /// <summary>
        /// Key for caching
        /// </summary>
        public static string SALESEMPLOYEE_ALL => "PowerStore.salesemployee.all";

        /// <summary>
        /// Key pattern to clear cache
        /// </summary>
        public static string SALESEMPLOYEE_PATTERN_KEY => "PowerStore.salesemployee.";

        #endregion
    }
}
