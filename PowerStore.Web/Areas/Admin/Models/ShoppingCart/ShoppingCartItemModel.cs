using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System;

namespace PowerStore.Web.Areas.Admin.Models.ShoppingCart
{
    public partial class ShoppingCartItemModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.CurrentCarts.Store")]
        public string Store { get; set; }
        [PowerStoreResourceDisplayName("Admin.CurrentCarts.Product")]
        public string ProductId { get; set; }
        [PowerStoreResourceDisplayName("Admin.CurrentCarts.Product")]
        public string ProductName { get; set; }
        public string AttributeInfo { get; set; }

        [PowerStoreResourceDisplayName("Admin.CurrentCarts.UnitPrice")]
        public string UnitPrice { get; set; }
        public decimal UnitPriceValue { get; set; }
        [PowerStoreResourceDisplayName("Admin.CurrentCarts.Quantity")]
        public int Quantity { get; set; }
        [PowerStoreResourceDisplayName("Admin.CurrentCarts.Total")]
        public string Total { get; set; }
        [PowerStoreResourceDisplayName("Admin.CurrentCarts.UpdatedOn")]
        public DateTime UpdatedOn { get; set; }
    }
}