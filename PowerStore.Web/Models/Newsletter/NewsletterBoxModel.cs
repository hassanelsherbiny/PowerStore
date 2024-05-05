using PowerStore.Core.Models;

namespace PowerStore.Web.Models.Newsletter
{
    public partial class NewsletterBoxModel : BaseModel
    {
        public string NewsletterEmail { get; set; }
        public bool AllowToUnsubscribe { get; set; }
    }
}