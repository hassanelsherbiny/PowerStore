using PowerStore.Api.DTOs.Customers;
using MediatR;

namespace PowerStore.Api.Commands.Models.Customers
{
    public class AddCustomerAddressCommand : IRequest<AddressDto>
    {
        public CustomerDto Customer { get; set; }
        public AddressDto Address { get; set; }
    }
}
