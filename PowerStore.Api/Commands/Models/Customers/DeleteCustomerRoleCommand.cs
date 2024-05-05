using PowerStore.Api.DTOs.Customers;
using MediatR;

namespace PowerStore.Api.Commands.Models.Customers
{
    public class DeleteCustomerRoleCommand : IRequest<bool>
    {
        public CustomerRoleDto Model { get; set; }
    }
}
