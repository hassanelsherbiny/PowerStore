using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Documents
{
    public class DocumentListModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Admin.Documents.Document.List.SearchName")]
        public string SearchName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.List.SearchNumber")]
        public string SearchNumber { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.List.SearchEmail")]
        public string SearchEmail { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.List.DocumentStatus")]
        public int StatusId { get; set; }

        public int Reference { get; set; }

        public string ObjectId { get; set; }
        public string CustomerId { get; set; }

    }
}
