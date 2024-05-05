using PowerStore.Domain.Messages;
using PowerStore.Core.Models;

namespace PowerStore.Web.Models.Common
{
    public class PopupModel : BaseEntityModel
    {
        public string Name { get; set; }
        public string Body { get; set; }
        public string CustomerActionId { get; set; }
        public PopupType PopupType { get; set; }
    }
}
