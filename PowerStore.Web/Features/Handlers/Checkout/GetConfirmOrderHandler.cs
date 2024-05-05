using PowerStore.Domain.Orders;
using PowerStore.Services.Commands.Models.Orders;
using PowerStore.Services.Localization;
using PowerStore.Web.Features.Models.Checkout;
using PowerStore.Web.Models.Checkout;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Features.Handlers.Checkout
{
    public class GetConfirmOrderHandler : IRequestHandler<GetConfirmOrder, CheckoutConfirmModel>
    {
        private readonly IMediator _mediator;
        private readonly ILocalizationService _localizationService;
        private readonly OrderSettings _orderSettings;

        public GetConfirmOrderHandler(
            IMediator mediator,
            ILocalizationService localizationService,
            OrderSettings orderSettings)
        {
            _mediator = mediator;
            _localizationService = localizationService;
            _orderSettings = orderSettings;
        }

        public async Task<CheckoutConfirmModel> Handle(GetConfirmOrder request, CancellationToken cancellationToken)
        {
            var model = new CheckoutConfirmModel();
            //terms of service
            model.TermsOfServiceOnOrderConfirmPage = _orderSettings.TermsOfServiceOnOrderConfirmPage;
            //min order amount validation
            var minOrderTotalAmountOk = await _mediator.Send(new ValidateShoppingCartTotalAmountCommand() { Customer = request.Customer, Cart = request.Cart });
            if (!minOrderTotalAmountOk)
            {
                model.MinOrderTotalWarning = string.Format(_localizationService.GetResource("Checkout.MinMaxOrderTotalAmount"));
            }
            return model;
        }
    }
}
