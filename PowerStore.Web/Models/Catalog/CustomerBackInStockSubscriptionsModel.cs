using PowerStore.Core.Models;
using PowerStore.Web.Models.Common;
using System.Collections.Generic;

namespace PowerStore.Web.Models.Catalog
{
    public partial class CustomerBackInStockSubscriptionsModel
    {
        public CustomerBackInStockSubscriptionsModel()
        {
            Subscriptions = new List<BackInStockSubscriptionModel>();
        }

        public IList<BackInStockSubscriptionModel> Subscriptions { get; set; }
        public PagerModel PagerModel { get; set; }

        #region Nested classes

        public partial class BackInStockSubscriptionModel : BaseEntityModel
        {
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public string AttributeDescription { get; set; }
            public string SeName { get; set; }
        }

        #endregion
    }
}