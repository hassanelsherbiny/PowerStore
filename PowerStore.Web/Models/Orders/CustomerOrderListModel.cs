using PowerStore.Domain.Common;
using PowerStore.Domain.Orders;
using PowerStore.Core.Models;
using System;
using System.Collections.Generic;

namespace PowerStore.Web.Models.Orders
{
    public partial class CustomerOrderListModel : BaseModel
    {
        public CustomerOrderListModel()
        {
            Orders = new List<OrderDetailsModel>();
            RecurringOrders = new List<RecurringOrderModel>();
            CancelRecurringPaymentErrors = new List<string>();
        }

        public IList<OrderDetailsModel> Orders { get; set; }
        public IList<RecurringOrderModel> RecurringOrders { get; set; }
        public IList<string> CancelRecurringPaymentErrors { get; set; }


        #region Nested classes

        public partial class OrderDetailsModel : BaseEntityModel
        {
            public string OrderTotal { get; set; }
            public bool IsReturnRequestAllowed { get; set; }
            public OrderStatus OrderStatusEnum { get; set; }
            public string OrderStatus { get; set; }
            public string PaymentStatus { get; set; }
            public string ShippingStatus { get; set; }
            public DateTime CreatedOn { get; set; }
            public int OrderNumber { get; set; }
            public string OrderCode { get; set; }
            public string CustomerEmail { get; set; }
        }

        public partial class RecurringOrderModel : BaseEntityModel
        {
            public string StartDate { get; set; }
            public string CycleInfo { get; set; }
            public string NextPayment { get; set; }
            public int TotalCycles { get; set; }
            public int CyclesRemaining { get; set; }
            public string InitialOrderId { get; set; }
            public bool CanCancel { get; set; }
        }

        #endregion
    }
}