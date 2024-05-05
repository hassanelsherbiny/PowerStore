using PowerStore.Services.Customers;
using PowerStore.Services.Localization;
using PowerStore.Services.Logging;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Api.Commands.Models.Customers
{
    public class DeleteCustomerRoleCommandHandler : IRequestHandler<DeleteCustomerRoleCommand, bool>
    {
        private readonly ICustomerService _customerService;
        private readonly ICustomerActivityService _customerActivityService;
        private readonly ILocalizationService _localizationService;

        public DeleteCustomerRoleCommandHandler(
            ICustomerService customerService,
            ICustomerActivityService customerActivityService,
            ILocalizationService localizationService)
        {
            _customerService = customerService;
            _customerActivityService = customerActivityService;
            _localizationService = localizationService;
        }

        public async Task<bool> Handle(DeleteCustomerRoleCommand request, CancellationToken cancellationToken)
        {
            var customerRole = await _customerService.GetCustomerRoleById(request.Model.Id);
            if (customerRole != null)
            {
                await _customerService.DeleteCustomerRole(customerRole);

                //activity log
                await _customerActivityService.InsertActivity("DeleteCustomerRole", customerRole.Id, _localizationService.GetResource("ActivityLog.DeleteCustomerRole"), customerRole.Name);
            }
            return true;
        }
    }
}
