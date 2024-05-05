using PowerStore.Services.Common;
using PowerStore.Services.Messages;
using PowerStore.Web.Commands.Models.Products;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Commands.Handler.Products
{
    public class SendProductEmailAFriendMessageCommandHandler : IRequestHandler<SendProductEmailAFriendMessageCommand, bool>
    {
        private readonly IWorkflowMessageService _workflowMessageService;

        public SendProductEmailAFriendMessageCommandHandler(IWorkflowMessageService workflowMessageService)
        {
            _workflowMessageService = workflowMessageService;
        }

        public async Task<bool> Handle(SendProductEmailAFriendMessageCommand request, CancellationToken cancellationToken)
        {
            await _workflowMessageService.SendProductEmailAFriendMessage(request.Customer, request.Store,
                               request.Language.Id, request.Product,
                               request.Model.YourEmailAddress, request.Model.FriendEmail,
                               FormatText.ConvertText(request.Model.PersonalMessage));

            return true;
        }
    }
}
