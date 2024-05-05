using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Discounts
{
    public partial class DiscountListModel : BaseModel
    {
        public DiscountListModel()
        {
            AvailableDiscountTypes = new List<SelectListItem>();
        }

        [PowerStoreResourceDisplayName("Admin.Promotions.Discounts.List.SearchDiscountCouponCode")]
        
        public string SearchDiscountCouponCode { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.Discounts.List.SearchDiscountName")]
        
        public string SearchDiscountName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.Discounts.List.SearchDiscountType")]
        public int SearchDiscountTypeId { get; set; }
        public IList<SelectListItem> AvailableDiscountTypes { get; set; }
    }
}