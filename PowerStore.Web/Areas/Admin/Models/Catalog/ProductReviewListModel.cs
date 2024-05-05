using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Areas.Admin.Models.Catalog
{
    public partial class ProductReviewListModel : BaseModel
    {
        public ProductReviewListModel()
        {
            AvailableStores = new List<SelectListItem>();
        }

        [PowerStoreResourceDisplayName("Admin.Catalog.ProductReviews.List.CreatedOnFrom")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnFrom { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.ProductReviews.List.CreatedOnTo")]
        [UIHint("DateNullable")]
        public DateTime? CreatedOnTo { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.ProductReviews.List.SearchText")]
        
        public string SearchText { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.ProductReviews.List.SearchStore")]
        public string SearchStoreId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.ProductReviews.List.SearchProduct")]
        public string SearchProductId { get; set; }

        public IList<SelectListItem> AvailableStores { get; set; }
    }
}