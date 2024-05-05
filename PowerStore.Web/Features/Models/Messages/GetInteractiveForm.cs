using PowerStore.Web.Models.Messages;
using MediatR;

namespace PowerStore.Web.Features.Models.Messages
{
    public class GetInteractiveForm : IRequest<InteractiveFormModel>
    {
        public string SystemName { get; set; }
    }
}
