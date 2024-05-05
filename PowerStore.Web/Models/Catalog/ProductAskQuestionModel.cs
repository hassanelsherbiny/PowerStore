using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Models.Catalog
{
    public partial class ProductAskQuestionModel : BaseEntityModel
    {
        public string ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductSeName { get; set; }

        [PowerStoreResourceDisplayName("Products.AskQuestion.Email")]
        public string Email { get; set; }

        [PowerStoreResourceDisplayName("Products.AskQuestion.FullName")]
        public string FullName { get; set; }

        [PowerStoreResourceDisplayName("Products.AskQuestion.Phone")]
        public string Phone { get; set; }

        [PowerStoreResourceDisplayName("Products.AskQuestion.Message")]
        public string Message { get; set; }

        public bool SuccessfullySent { get; set; }
        public string Result { get; set; }

        public bool DisplayCaptcha { get; set; }

    }
}