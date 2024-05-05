using PowerStore.Api.DTOs.Customers;
using MediatR;

namespace PowerStore.Api.Commands.Models.Customers
{
    public class UpdateCustomerRoleCommand : IRequest<CustomerRoleDto>
    {
        public CustomerRoleDto Model { get; set; }
    }
}
