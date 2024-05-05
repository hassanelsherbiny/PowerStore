using PowerStore.Domain.Customers;
using PowerStore.Domain.Localization;
using PowerStore.Web.Models.Customer;
using MediatR;

namespace PowerStore.Web.Features.Models.Customers
{
    public class GetTwoFactorAuthentication : IRequest<CustomerInfoModel.TwoFactorAuthenticationModel>
    {
        public Customer Customer { get; set; }
        public Language Language { get; set; }
    }
}
