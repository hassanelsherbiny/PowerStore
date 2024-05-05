using PowerStore.Domain.Customers;
using PowerStore.Services.Common;
using PowerStore.Services.Messages;
using PowerStore.Web.Commands.Models.Customers;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Commands.Handler.Customers
{
    public class PasswordRecoverySendCommandHandler : IRequestHandler<PasswordRecoverySendCommand, bool>
    {
        private readonly IGenericAttributeService _genericAttributeService;
        private readonly IWorkflowMessageService _workflowMessageService;

        public PasswordRecoverySendCommandHandler(
            IGenericAttributeService genericAttributeService,
            IWorkflowMessageService workflowMessageService)
        {
            _genericAttributeService = genericAttributeService;
            _workflowMessageService = workflowMessageService;
        }

        public async Task<bool> Handle(PasswordRecoverySendCommand request, CancellationToken cancellationToken)
        {
            //save token and current date
            var passwordRecoveryToken = Guid.NewGuid();
            await _genericAttributeService.SaveAttribute(request.Customer, SystemCustomerAttributeNames.PasswordRecoveryToken, passwordRecoveryToken.ToString());
            DateTime? generatedDateTime = DateTime.UtcNow;
            await _genericAttributeService.SaveAttribute(request.Customer, SystemCustomerAttributeNames.PasswordRecoveryTokenDateGenerated, generatedDateTime);

            //send email
            await _workflowMessageService.SendCustomerPasswordRecoveryMessage(request.Customer, request.Store, request.Language.Id);

            return true;
        }
    }
}
