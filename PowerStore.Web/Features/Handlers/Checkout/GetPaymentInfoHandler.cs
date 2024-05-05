using PowerStore.Domain.Orders;
using PowerStore.Web.Features.Models.Checkout;
using PowerStore.Web.Models.Checkout;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Features.Handlers.Checkout
{
    public class GetPaymentInfoHandler : IRequestHandler<GetPaymentInfo, CheckoutPaymentInfoModel>
    {
        private readonly OrderSettings _orderSettings;

        public GetPaymentInfoHandler(OrderSettings orderSettings)
        {
            _orderSettings = orderSettings;
        }

        public async Task<CheckoutPaymentInfoModel> Handle(GetPaymentInfo request, CancellationToken cancellationToken)
        {
            request.PaymentMethod.GetPublicViewComponent(out string viewComponentName);

            var model = new CheckoutPaymentInfoModel {
                PaymentViewComponentName = viewComponentName,
                DisplayOrderTotals = _orderSettings.OnePageCheckoutDisplayOrderTotalsOnPaymentInfoTab
            };
            return await Task.FromResult(model);
        }
    }
}
