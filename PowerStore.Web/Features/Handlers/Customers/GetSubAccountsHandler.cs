using PowerStore.Domain.Customers;
using PowerStore.Services.Common;
using PowerStore.Services.Customers;
using PowerStore.Web.Features.Models.Customers;
using PowerStore.Web.Models.Customer;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Features.Handlers.Customers
{
    public class GetSubAccountsHandler : IRequestHandler<GetSubAccounts, IList<SubAccountSimpleModel>>
    {
        private readonly ICustomerService _customerService;
        public GetSubAccountsHandler(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<IList<SubAccountSimpleModel>> Handle(GetSubAccounts request, CancellationToken cancellationToken)
        {
            var model = new List<SubAccountSimpleModel>();

            var subaccouns = await _customerService.GetAllCustomers(ownerId: request.Customer.Id);
            foreach (var item in subaccouns)
            {
                model.Add(new SubAccountSimpleModel() {
                    Id = item.Id,
                    Email = item.Email,
                    Active = item.Active,
                    FirstName = item.GetAttributeFromEntity<string>(SystemCustomerAttributeNames.FirstName),
                    LastName = item.GetAttributeFromEntity<string>(SystemCustomerAttributeNames.LastName)
                });
            }

            return model;
        }
    }
}
