using PowerStore.Domain.Customers;
using PowerStore.Web.Models.Customer;
using MediatR;

namespace PowerStore.Web.Features.Models.Customers
{
    public class GetPasswordRecoveryConfirm : IRequest<PasswordRecoveryConfirmModel>
    {
        public Customer Customer { get; set; }
        public string Token { get; set; }
    }
}
