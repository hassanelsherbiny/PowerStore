using PowerStore.Api.DTOs.Customers;
using MediatR;

namespace PowerStore.Api.Commands.Models.Customers
{
    public class UpdateCustomerAddressCommand : IRequest<AddressDto>
    {
        public CustomerDto Customer { get; set; }
        public AddressDto Address { get; set; }
    }
}
