using PowerStore.Api.DTOs.Customers;
using MediatR;

namespace PowerStore.Api.Commands.Models.Customers
{
    public class AddCustomerRoleCommand : IRequest<CustomerRoleDto>
    {
        public CustomerRoleDto Model { get; set; }
    }
}
