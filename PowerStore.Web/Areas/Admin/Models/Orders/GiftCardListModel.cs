using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Orders
{
    public partial class GiftCardListModel : BaseModel
    {
        public GiftCardListModel()
        {
            ActivatedList = new List<SelectListItem>();
        }

        [PowerStoreResourceDisplayName("Admin.GiftCards.List.CouponCode")]
        
        public string CouponCode { get; set; }

        [PowerStoreResourceDisplayName("Admin.GiftCards.List.RecipientName")]
        
        public string RecipientName { get; set; }

        [PowerStoreResourceDisplayName("Admin.GiftCards.List.Activated")]
        public int ActivatedId { get; set; }
        [PowerStoreResourceDisplayName("Admin.GiftCards.List.Activated")]
        public IList<SelectListItem> ActivatedList { get; set; }
    }
}