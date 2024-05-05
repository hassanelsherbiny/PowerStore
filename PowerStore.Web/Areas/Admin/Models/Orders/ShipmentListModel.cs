using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Areas.Admin.Models.Orders
{
    public partial class ShipmentListModel : BaseModel
    {
        public ShipmentListModel()
        {
            AvailableCountries = new List<SelectListItem>();
            AvailableStates = new List<SelectListItem>();
            AvailableWarehouses = new List<SelectListItem>();
        }

        [PowerStoreResourceDisplayName("Admin.Orders.Shipments.List.StartDate")]
        [UIHint("DateNullable")]
        public DateTime? StartDate { get; set; }

        [PowerStoreResourceDisplayName("Admin.Orders.Shipments.List.EndDate")]
        [UIHint("DateNullable")]
        public DateTime? EndDate { get; set; }

        [PowerStoreResourceDisplayName("Admin.Orders.Shipments.List.TrackingNumber")]
        
        public string TrackingNumber { get; set; }
        
        public IList<SelectListItem> AvailableCountries { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Shipments.List.Country")]
        public string CountryId { get; set; }

        public IList<SelectListItem> AvailableStates { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Shipments.List.StateProvince")]
        public int StateProvinceId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Orders.Shipments.List.City")]
        
        public string City { get; set; }

        [PowerStoreResourceDisplayName("Admin.Orders.Shipments.List.LoadNotShipped")]
        public bool LoadNotShipped { get; set; }


        [PowerStoreResourceDisplayName("Admin.Orders.Shipments.List.Warehouse")]
        public string WarehouseId { get; set; }
        public IList<SelectListItem> AvailableWarehouses { get; set; }

        public string StoreId { get; set; }
        public string VendorId { get; set; }
    }
}