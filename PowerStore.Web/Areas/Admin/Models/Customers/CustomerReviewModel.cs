using PowerStore.Core.Models;
using PowerStore.Web.Areas.Admin.Models.Common;

namespace PowerStore.Web.Areas.Admin.Models.Customers
{
    public partial class CustomerReviewModel
    {
        public string CustomerId { get; set; }

        public ReviewModel Review { get; set; }
    }
}