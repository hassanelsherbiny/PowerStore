using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Models.Catalog
{
    public partial class ProductAskQuestionSimpleModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Products.AskQuestion.Email")]
        public string AskQuestionEmail { get; set; }

        [PowerStoreResourceDisplayName("Products.AskQuestion.FullName")]
        public string AskQuestionFullName { get; set; }

        [PowerStoreResourceDisplayName("Products.AskQuestion.Phone")]
        public string AskQuestionPhone { get; set; }

        [PowerStoreResourceDisplayName("Products.AskQuestion.Message")]
        public string AskQuestionMessage { get; set; }

        public bool DisplayCaptcha { get; set; }

    }
}