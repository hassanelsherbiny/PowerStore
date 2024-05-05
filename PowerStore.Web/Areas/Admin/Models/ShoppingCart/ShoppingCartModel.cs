using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.ShoppingCart
{
    public partial class ShoppingCartModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Admin.CurrentCarts.Customer")]
        public string CustomerId { get; set; }
        [PowerStoreResourceDisplayName("Admin.CurrentCarts.Customer")]
        public string CustomerEmail { get; set; }

        [PowerStoreResourceDisplayName("Admin.CurrentCarts.TotalItems")]
        public int TotalItems { get; set; }
    }
}