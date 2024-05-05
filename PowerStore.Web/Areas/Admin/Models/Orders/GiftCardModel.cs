using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Orders
{
    public partial class GiftCardModel : BaseEntityModel
    {
        public GiftCardModel()
        {
            AvailableCurrencies = new List<SelectListItem>();
        }
        [PowerStoreResourceDisplayName("Admin.GiftCards.Fields.GiftCardType")]
        public int GiftCardTypeId { get; set; }

        [PowerStoreResourceDisplayName("Admin.GiftCards.Fields.Order")]
        public string PurchasedWithOrderId { get; set; }
        public int PurchasedWithOrderNumber { get; set; }

        [PowerStoreResourceDisplayName("Admin.GiftCards.Fields.Amount")]
        public decimal Amount { get; set; }

        [PowerStoreResourceDisplayName("Admin.GiftCards.Fields.CurrencyCode")]
        public string CurrencyCode { get; set; }
        public IList<SelectListItem> AvailableCurrencies { get; set; }


        [PowerStoreResourceDisplayName("Admin.GiftCards.Fields.Amount")]
        public string AmountStr { get; set; }

        [PowerStoreResourceDisplayName("Admin.GiftCards.Fields.RemainingAmount")]
        public string RemainingAmountStr { get; set; }

        [PowerStoreResourceDisplayName("Admin.GiftCards.Fields.IsGiftCardActivated")]
        public bool IsGiftCardActivated { get; set; }

        [PowerStoreResourceDisplayName("Admin.GiftCards.Fields.GiftCardCouponCode")]

        public string GiftCardCouponCode { get; set; }

        [PowerStoreResourceDisplayName("Admin.GiftCards.Fields.RecipientName")]

        public string RecipientName { get; set; }

        [PowerStoreResourceDisplayName("Admin.GiftCards.Fields.RecipientEmail")]

        public string RecipientEmail { get; set; }

        [PowerStoreResourceDisplayName("Admin.GiftCards.Fields.SenderName")]

        public string SenderName { get; set; }

        [PowerStoreResourceDisplayName("Admin.GiftCards.Fields.SenderEmail")]

        public string SenderEmail { get; set; }

        [PowerStoreResourceDisplayName("Admin.GiftCards.Fields.Message")]

        public string Message { get; set; }

        [PowerStoreResourceDisplayName("Admin.GiftCards.Fields.IsRecipientNotified")]
        public bool IsRecipientNotified { get; set; }

        [PowerStoreResourceDisplayName("Admin.GiftCards.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        #region Nested classes

        public partial class GiftCardUsageHistoryModel : BaseEntityModel
        {
            [PowerStoreResourceDisplayName("Admin.GiftCards.History.UsedValue")]
            public string UsedValue { get; set; }

            [PowerStoreResourceDisplayName("Admin.GiftCards.History.Order")]
            public string OrderId { get; set; }
            public int OrderNumber { get; set; }

            [PowerStoreResourceDisplayName("Admin.GiftCards.History.CreatedOn")]
            public DateTime CreatedOn { get; set; }
        }

        #endregion
    }
}