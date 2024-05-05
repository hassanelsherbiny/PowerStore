using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Areas.Admin.Models.Affiliates
{
    public partial class AffiliateListModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Admin.Affiliates.List.SearchFirstName")]
        
        public string SearchFirstName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Affiliates.List.SearchLastName")]
        
        public string SearchLastName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Affiliates.List.SearchFriendlyUrlName")]
        
        public string SearchFriendlyUrlName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Affiliates.List.LoadOnlyWithOrders")]
        public bool LoadOnlyWithOrders { get; set; }
        [PowerStoreResourceDisplayName("Admin.Affiliates.List.OrdersCreatedFromUtc")]
        [UIHint("DateNullable")]
        public DateTime? OrdersCreatedFromUtc { get; set; }
        [PowerStoreResourceDisplayName("Admin.Affiliates.List.OrdersCreatedToUtc")]
        [UIHint("DateNullable")]
        public DateTime? OrdersCreatedToUtc { get; set; }
    }
}