using PowerStore.Domain.Customers;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Customer;
using MediatR;

namespace PowerStore.Web.Commands.Models.Customers
{
    public class PasswordRecoverySendCommand : IRequest<bool>
    {
        public PasswordRecoveryModel Model { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public Language Language { get; set; }
    }
}
