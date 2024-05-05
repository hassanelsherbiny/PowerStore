
using PowerStore.Framework;
using PowerStore.Framework.Mvc;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using PowerStore.Core.ModelBinding;

namespace PowerStore.Web.Areas.Admin.Models.Catalog
{
    public partial class BulkEditProductModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.Catalog.BulkEdit.Fields.Name")]
        
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.BulkEdit.Fields.SKU")]
        
        public string Sku { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.BulkEdit.Fields.Price")]
        public decimal Price { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.BulkEdit.Fields.OldPrice")]
        public decimal OldPrice { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.BulkEdit.Fields.ManageInventoryMethod")]
        public string ManageInventoryMethod { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.BulkEdit.Fields.StockQuantity")]
        public int StockQuantity { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.BulkEdit.Fields.Published")]
        public bool Published { get; set; }
    }
}