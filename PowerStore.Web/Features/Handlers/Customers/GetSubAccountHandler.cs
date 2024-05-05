using PowerStore.Domain.Customers;
using PowerStore.Services.Common;
using PowerStore.Services.Customers;
using PowerStore.Web.Features.Models.Customers;
using PowerStore.Web.Models.Customer;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Features.Handlers.Customers
{
    public class GetSubAccountHandler : IRequestHandler<GetSubAccount, SubAccountModel>
    {
        private readonly ICustomerService _customerService;
        public GetSubAccountHandler(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<SubAccountModel> Handle(GetSubAccount request, CancellationToken cancellationToken)
        {
            if (request.CurrentCustomer == null)
                throw new ArgumentNullException("CurrentCustomer");

            var model = new SubAccountModel();

            var subaccount = await _customerService.GetCustomerById(customerId: request.CustomerId);
            if (subaccount != null && subaccount.OwnerId == request.CurrentCustomer.Id)
            {
                model = new SubAccountModel() {
                    Id = subaccount.Id,
                    Email = subaccount.Email,
                    Active = subaccount.Active,
                    FirstName = subaccount.GetAttributeFromEntity<string>(SystemCustomerAttributeNames.FirstName),
                    LastName = subaccount.GetAttributeFromEntity<string>(SystemCustomerAttributeNames.LastName)
                };
            }

            return model;
        }
    }
}
