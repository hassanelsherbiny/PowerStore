using System;
using PowerStore.Web.Areas.Admin.Models.Common;
using PowerStore.Core.Models;
using PowerStore.Core.ModelBinding;

namespace PowerStore.Web.Areas.Admin.Models.Affiliates
{
    public partial class AffiliateModel : BaseEntityModel
    {
        public AffiliateModel()
        {
            Address = new AddressModel();
        }

        [PowerStoreResourceDisplayName("Admin.Affiliates.Fields.ID")]
        public override string Id { get; set; }

        [PowerStoreResourceDisplayName("Admin.Affiliates.Fields.URL")]
        public string Url { get; set; }


        [PowerStoreResourceDisplayName("Admin.Affiliates.Fields.AdminComment")]
        
        public string AdminComment { get; set; }

        [PowerStoreResourceDisplayName("Admin.Affiliates.Fields.FriendlyUrlName")]
        
        public string FriendlyUrlName { get; set; }
        
        [PowerStoreResourceDisplayName("Admin.Affiliates.Fields.Active")]
        public bool Active { get; set; }

        public AddressModel Address { get; set; }

        #region Nested classes
        
        public partial class AffiliatedOrderModel : BaseEntityModel
        {
            [PowerStoreResourceDisplayName("Admin.Affiliates.Orders.Order")]
            public override string Id { get; set; }
            public int OrderNumber { get; set; }

            public string OrderCode { get; set; }

            [PowerStoreResourceDisplayName("Admin.Affiliates.Orders.OrderStatus")]
            public string OrderStatus { get; set; }

            [PowerStoreResourceDisplayName("Admin.Affiliates.Orders.PaymentStatus")]
            public string PaymentStatus { get; set; }

            [PowerStoreResourceDisplayName("Admin.Affiliates.Orders.ShippingStatus")]
            public string ShippingStatus { get; set; }

            [PowerStoreResourceDisplayName("Admin.Affiliates.Orders.OrderTotal")]
            public string OrderTotal { get; set; }

            [PowerStoreResourceDisplayName("Admin.Affiliates.Orders.CreatedOn")]
            public DateTime CreatedOn { get; set; }
        }

        public partial class AffiliatedCustomerModel : BaseEntityModel
        {
            [PowerStoreResourceDisplayName("Admin.Affiliates.Customers.Name")]
            public string Name { get; set; }
        }

        #endregion
    }
}