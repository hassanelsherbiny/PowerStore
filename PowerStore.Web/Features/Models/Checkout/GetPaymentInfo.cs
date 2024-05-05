using PowerStore.Services.Payments;
using PowerStore.Web.Models.Checkout;
using MediatR;

namespace PowerStore.Web.Features.Models.Checkout
{
    public class GetPaymentInfo : IRequest<CheckoutPaymentInfoModel>
    {
        public IPaymentMethod PaymentMethod { get; set; }
    }
}
