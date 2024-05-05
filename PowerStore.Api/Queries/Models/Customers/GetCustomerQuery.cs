using PowerStore.Api.DTOs.Customers;
using MediatR;

namespace PowerStore.Api.Queries.Models.Customers
{
    public class GetCustomerQuery : IRequest<CustomerDto>
    {
        public string Email { get; set; }
    }
}
