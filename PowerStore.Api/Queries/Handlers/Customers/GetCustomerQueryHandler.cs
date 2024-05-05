using PowerStore.Api.DTOs.Customers;
using PowerStore.Api.Extensions;
using PowerStore.Api.Queries.Models.Customers;
using PowerStore.Services.Customers;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Api.Queries.Handlers.Customers
{
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, CustomerDto>
    {
        private readonly ICustomerService _customerService;

        public GetCustomerQueryHandler(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<CustomerDto> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            return (await _customerService.GetCustomerByEmail(request.Email)).ToModel();
        }
    }
}
