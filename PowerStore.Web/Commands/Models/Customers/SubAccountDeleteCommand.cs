using PowerStore.Domain.Customers;
using MediatR;

namespace PowerStore.Web.Commands.Models.Customers
{
    public class SubAccountDeleteCommand : IRequest<(bool success, string error)>
    {
        public Customer CurrentCustomer { get; set; }
        public string CustomerId { get; set; }
    }
}
