using PowerStore.Core.Models;
using PowerStore.Domain.Messages;

namespace PowerStore.Web.Models.Messages
{
    public partial class InteractiveFormModel : BaseEntityModel
    {
        public InteractiveForm InteractiveForm { get; set; }
        public string Body { get; set; }
    }
}