using PowerStore.Domain.Payments;
using PowerStore.Services.Orders;
using PowerStore.Web.Features.Models.Checkout;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Features.Handlers.Checkout
{
    public class GetIsPaymentWorkflowRequiredHandler : IRequestHandler<GetIsPaymentWorkflowRequired, bool>
    {
        private readonly IOrderTotalCalculationService _orderTotalCalculationService;
        private readonly PaymentSettings _paymentSettings;

        public GetIsPaymentWorkflowRequiredHandler(IOrderTotalCalculationService orderTotalCalculationService, PaymentSettings paymentSettings)
        {
            _orderTotalCalculationService = orderTotalCalculationService;
            _paymentSettings = paymentSettings;
        }
        public async Task<bool> Handle(GetIsPaymentWorkflowRequired request, CancellationToken cancellationToken)
        {
            bool result = true;
            //check whether order total equals zero
            decimal? shoppingCartTotalBase = (await _orderTotalCalculationService.GetShoppingCartTotal(request.Cart, useRewardPoints: request.UseRewardPoints)).shoppingCartTotal;
            if (shoppingCartTotalBase.HasValue && shoppingCartTotalBase.Value == decimal.Zero && !_paymentSettings.ShowPaymentMethodIfCartIsZero)
                result = false;
            return result;
        }
    }
}
