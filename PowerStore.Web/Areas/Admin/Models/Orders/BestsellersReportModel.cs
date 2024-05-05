using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Areas.Admin.Models.Orders
{
    public partial class BestsellersReportModel : BaseModel
    {
        public BestsellersReportModel()
        {
            AvailableStores = new List<SelectListItem>();
            AvailableOrderStatuses = new List<SelectListItem>();
            AvailablePaymentStatuses = new List<SelectListItem>();
            AvailableCountries = new List<SelectListItem>();
            AvailableVendors = new List<SelectListItem>();

        }

        [PowerStoreResourceDisplayName("Admin.Reports.Bestsellers.Store")]
        public string StoreId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Reports.Bestsellers.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [PowerStoreResourceDisplayName("Admin.Reports.Bestsellers.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }


        [PowerStoreResourceDisplayName("Admin.Reports.Bestsellers.OrderStatus")]
        public int OrderStatusId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Reports.Bestsellers.PaymentStatus")]
        public int PaymentStatusId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Reports.Bestsellers.BillingCountry")]
        public string BillingCountryId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Reports.Bestsellers.Vendor")]
        public string VendorId { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }

        public IList<SelectListItem> AvailableOrderStatuses { get; set; }
        public IList<SelectListItem> AvailablePaymentStatuses { get; set; }
        public IList<SelectListItem> AvailableCountries { get; set; }
        public IList<SelectListItem> AvailableVendors { get; set; }
        public bool IsLoggedInAsVendor { get; set; }
    }
}