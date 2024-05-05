using PowerStore.Core.ModelBinding;

namespace PowerStore.Web.Areas.Admin.Models.Settings
{
    public class AdminSearchSettingsModel
    {
        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.SearchInProducts")]
        public bool SearchInProducts { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.ProductsDisplayOrder")]
        public int ProductsDisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.SearchInCategories")]
        public bool SearchInCategories { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.CategoriesDisplayOrder")]
        public int CategoriesDisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.SearchInManufacturers")]
        public bool SearchInManufacturers { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.ManufacturersDisplayOrder")]
        public int ManufacturersDisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.SearchInTopics")]
        public bool SearchInTopics { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.TopicsDisplayOrder")]
        public int TopicsDisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.SearchInNews")]
        public bool SearchInNews { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.NewsDisplayOrder")]
        public int NewsDisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.SearchInBlogs")]
        public bool SearchInBlogs { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.BlogsDisplayOrder")]
        public int BlogsDisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.SearchInCustomers")]
        public bool SearchInCustomers { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.CustomersDisplayOrder")]
        public int CustomersDisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.SearchInOrders")]
        public bool SearchInOrders { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.OrdersDisplayOrder")]
        public int OrdersDisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.MinSearchTermLength")]
        public int MinSearchTermLength { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.MaxSearchResultsCount")]
        public int MaxSearchResultsCount { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.SearchInMenu")]
        public bool SearchInMenu { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.AdminSearch.Fields.MenuDisplayOrder")]
        public int MenuDisplayOrder { get; set; }
    }
}
