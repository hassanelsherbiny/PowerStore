using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System;

namespace PowerStore.Web.Areas.Admin.Models.Orders
{
    public partial class RecurringPaymentModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.RecurringPayments.Fields.ID")]
        public override string Id { get; set; }

        [PowerStoreResourceDisplayName("Admin.RecurringPayments.Fields.CycleLength")]
        public int CycleLength { get; set; }

        [PowerStoreResourceDisplayName("Admin.RecurringPayments.Fields.CyclePeriod")]
        public int CyclePeriodId { get; set; }

        [PowerStoreResourceDisplayName("Admin.RecurringPayments.Fields.CyclePeriod")]
        public string CyclePeriodStr { get; set; }

        [PowerStoreResourceDisplayName("Admin.RecurringPayments.Fields.TotalCycles")]
        public int TotalCycles { get; set; }

        [PowerStoreResourceDisplayName("Admin.RecurringPayments.Fields.StartDate")]
        public string StartDate { get; set; }

        [PowerStoreResourceDisplayName("Admin.RecurringPayments.Fields.IsActive")]
        public bool IsActive { get; set; }

        [PowerStoreResourceDisplayName("Admin.RecurringPayments.Fields.NextPaymentDate")]
        public string NextPaymentDate { get; set; }

        [PowerStoreResourceDisplayName("Admin.RecurringPayments.Fields.CyclesRemaining")]
        public int CyclesRemaining { get; set; }

        [PowerStoreResourceDisplayName("Admin.RecurringPayments.Fields.InitialOrder")]
        public string InitialOrderId { get; set; }

        [PowerStoreResourceDisplayName("Admin.RecurringPayments.Fields.Customer")]
        public string CustomerId { get; set; }
        [PowerStoreResourceDisplayName("Admin.RecurringPayments.Fields.Customer")]
        public string CustomerEmail { get; set; }

        [PowerStoreResourceDisplayName("Admin.RecurringPayments.Fields.PaymentType")]
        public string PaymentType { get; set; }
        
        public bool CanCancelRecurringPayment { get; set; }

        #region Nested classes


        public partial class RecurringPaymentHistoryModel : BaseEntityModel
        {
            [PowerStoreResourceDisplayName("Admin.RecurringPayments.History.Order")]
            public string OrderId { get; set; }
            public int OrderNumber { get; set; }

            public string RecurringPaymentId { get; set; }

            [PowerStoreResourceDisplayName("Admin.RecurringPayments.History.OrderStatus")]
            public string OrderStatus { get; set; }

            [PowerStoreResourceDisplayName("Admin.RecurringPayments.History.PaymentStatus")]
            public string PaymentStatus { get; set; }

            [PowerStoreResourceDisplayName("Admin.RecurringPayments.History.ShippingStatus")]
            public string ShippingStatus { get; set; }

            [PowerStoreResourceDisplayName("Admin.RecurringPayments.History.CreatedOn")]
            public DateTime CreatedOn { get; set; }
        }

        #endregion
    }
}