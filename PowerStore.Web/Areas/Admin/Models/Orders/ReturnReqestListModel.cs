using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Areas.Admin.Models.Orders
{
    public partial class ReturnReqestListModel : BaseModel
    {
        public ReturnReqestListModel()
        {
            ReturnRequestStatus = new List<SelectListItem>();
        }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.List.SearchCustomerEmail")]
        public string SearchCustomerEmail { get; set; }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.List.SearchReturnRequestStatus")]
        public int SearchReturnRequestStatusId { get; set; }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.List.GoDirectlyToId")]
        public string GoDirectlyToId { get; set; }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.List.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [PowerStoreResourceDisplayName("Admin.ReturnRequests.List.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        public string StoreId { get; set; }

        public IList<SelectListItem> ReturnRequestStatus { get; set; }
    }
}