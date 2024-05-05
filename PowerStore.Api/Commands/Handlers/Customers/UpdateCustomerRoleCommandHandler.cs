using PowerStore.Api.DTOs.Customers;
using PowerStore.Api.Extensions;
using PowerStore.Services.Customers;
using PowerStore.Services.Localization;
using PowerStore.Services.Logging;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Api.Commands.Models.Customers
{
    public class UpdateCustomerRoleCommandHandler : IRequestHandler<UpdateCustomerRoleCommand, CustomerRoleDto>
    {
        private readonly ICustomerService _customerService;
        private readonly ICustomerActivityService _customerActivityService;
        private readonly ILocalizationService _localizationService;

        public UpdateCustomerRoleCommandHandler(
            ICustomerService customerService,
            ICustomerActivityService customerActivityService,
            ILocalizationService localizationService)
        {
            _customerService = customerService;
            _customerActivityService = customerActivityService;
            _localizationService = localizationService;
        }

        public async Task<CustomerRoleDto> Handle(UpdateCustomerRoleCommand request, CancellationToken cancellationToken)
        {
            var customerRole = await _customerService.GetCustomerRoleById(request.Model.Id);
            customerRole = request.Model.ToEntity(customerRole);
            await _customerService.UpdateCustomerRole(customerRole);

            //activity log
            await _customerActivityService.InsertActivity("EditCustomerRole", customerRole.Id, _localizationService.GetResource("ActivityLog.EditCustomerRole"), customerRole.Name);

            return customerRole.ToModel();
        }
    }
}
