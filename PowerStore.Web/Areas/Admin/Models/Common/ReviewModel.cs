using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Common
{
    public partial class ReviewModel : BaseEntityModel
    {
        /// <summary>
        /// Gets or sets the title
        /// </summary>
        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Reviews.Title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the review text
        /// </summary>
        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Reviews.Review")]
        public string ReviewText { get; set; }
    }
}