using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using PowerStore.Web.Areas.Admin.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Areas.Admin.Models.Orders
{
    public partial class ReturnRequestModel : BaseEntityModel
    {
        public ReturnRequestModel()
        {
            Items = new List<ReturnRequestItemModel>();
        }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.Fields.ID")]
        public override string Id { get; set; }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.Fields.ID")]
        public int ReturnNumber { get; set; }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.Fields.Order")]
        public string OrderId { get; set; }
        public int OrderNumber { get; set; }
        public string OrderCode { get; set; }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.Fields.ExternalId")]
        public string ExternalId { get; set; }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.Fields.Customer")]
        public string CustomerId { get; set; }
        [PowerStoreResourceDisplayName("Admin.ReturnRequests.Fields.Customer")]
        public string CustomerInfo { get; set; }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.Fields.Total")]
        public string Total { get; set; }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.Fields.CustomerComments")]
        public string CustomerComments { get; set; }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.Fields.StaffNotes")]
        public string StaffNotes { get; set; }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.Fields.Status")]
        public int ReturnRequestStatusId { get; set; }
        [PowerStoreResourceDisplayName("Admin.ReturnRequests.Fields.Status")]
        public string ReturnRequestStatusStr { get; set; }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.Fields.Quantity")]
        public int Quantity { get; set; }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.Fields.PickupDate")]
        public DateTime PickupDate { get; set; }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.Fields.PickupAddress")]
        public AddressModel PickupAddress { get; set; }

        public List<ReturnRequestItemModel> Items { get; set; }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.NotifyCustomer")]
        public bool NotifyCustomer { get; set; }

        //return request notes
        [PowerStoreResourceDisplayName("Admin.ReturnRequests.ReturnRequestNotes.Fields.DisplayToCustomer")]
        public bool AddReturnRequestNoteDisplayToCustomer { get; set; }
        [PowerStoreResourceDisplayName("Admin.ReturnRequests.ReturnRequestNotes.Fields.Note")]
        public string AddReturnRequestNoteMessage { get; set; }
        public bool AddReturnRequestNoteHasDownload { get; set; }
        [PowerStoreResourceDisplayName("Admin.ReturnRequests.ReturnRequestNotes.Fields.Download")]
        [UIHint("Download")]
        public string AddReturnRequestNoteDownloadId { get; set; }

        public class ReturnRequestItemModel : BaseEntityModel
        {
            public string ProductId { get; set; }

            public string ProductName { get; set; }

            public string UnitPrice { get; set; }

            public int Quantity { get; set; }

            public string ReasonForReturn { get; set; }

            public string RequestedAction { get; set; }
        }

        public partial class ReturnRequestNote : BaseEntityModel
        {
            public string ReturnRequestId { get; set; }
            [PowerStoreResourceDisplayName("Admin.ReturnRequests.ReturnRequestNotes.Fields.DisplayToCustomer")]
            public bool DisplayToCustomer { get; set; }
            [PowerStoreResourceDisplayName("Admin.ReturnRequests.ReturnRequestNotes.Fields.Note")]
            public string Note { get; set; }
            [PowerStoreResourceDisplayName("Admin.ReturnRequests.ReturnRequestNotes.Fields.Download")]
            public string DownloadId { get; set; }
            [PowerStoreResourceDisplayName("Admin.ReturnRequests.ReturnRequestNotes.Fields.Download")]
            public Guid DownloadGuid { get; set; }
            [PowerStoreResourceDisplayName("Admin.ReturnRequests.ReturnRequestNotes.Fields.CreatedOn")]
            public DateTime CreatedOn { get; set; }
            [PowerStoreResourceDisplayName("Admin.ReturnRequests.ReturnRequestNotes.Fields.CreatedByCustomer")]
            public bool CreatedByCustomer { get; set; }
        }
    }
}