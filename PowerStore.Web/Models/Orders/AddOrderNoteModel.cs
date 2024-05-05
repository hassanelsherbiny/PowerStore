using PowerStore.Core.Models;

namespace PowerStore.Web.Models.Orders
{
    public class AddOrderNoteModel : BaseModel
    {
        public string OrderId { get; set; }
        public string Note { get; set; }
    }
}
