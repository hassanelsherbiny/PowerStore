using PowerStore.Domain.Customers;
using PowerStore.Domain.Stores;
using MediatR;

namespace PowerStore.Web.Commands.Models.Customers
{
    public class DeleteAccountCommand : IRequest<bool>
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }
    }
}
