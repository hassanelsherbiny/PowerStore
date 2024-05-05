using PowerStore.Domain.Customers;
using PowerStore.Domain.Tax;
using PowerStore.Services.Catalog;
using PowerStore.Services.Directory;
using PowerStore.Services.Helpers;
using PowerStore.Services.Localization;
using PowerStore.Services.Orders;
using PowerStore.Services.Queries.Models.Orders;
using PowerStore.Web.Features.Models.Orders;
using PowerStore.Web.Models.Orders;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Features.Handlers.Orders
{
    public class GetReturnRequestsHandler : IRequestHandler<GetReturnRequests, CustomerReturnRequestsModel>
    {
        private readonly IOrderService _orderService;
        private readonly ICurrencyService _currencyService;
        private readonly ILocalizationService _localizationService;
        private readonly IDateTimeHelper _dateTimeHelper;
        private readonly IPriceFormatter _priceFormatter;
        private readonly IMediator _mediator;

        public GetReturnRequestsHandler(
            IOrderService orderService,
            ICurrencyService currencyService,
            ILocalizationService localizationService,
            IDateTimeHelper dateTimeHelper,
            IPriceFormatter priceFormatter,
            IMediator mediator)
        {
            _orderService = orderService;
            _currencyService = currencyService;
            _localizationService = localizationService;
            _dateTimeHelper = dateTimeHelper;
            _priceFormatter = priceFormatter;
            _mediator = mediator;
        }

        public async Task<CustomerReturnRequestsModel> Handle(GetReturnRequests request, CancellationToken cancellationToken)
        {
            var model = new CustomerReturnRequestsModel();
            
            var query = new GetReturnRequestQuery() {
                StoreId = request.Store.Id,
            };

            if (request.Customer.IsOwner())
                query.OwnerId = request.Customer.Id;
            else
                query.CustomerId = request.Customer.Id;

            var returnRequests = await _mediator.Send(query);

            foreach (var returnRequest in returnRequests)
            {
                var order = await _orderService.GetOrderById(returnRequest.OrderId);
                decimal total = 0;
                foreach (var rrItem in returnRequest.ReturnRequestItems)
                {
                    var orderItem = order.OrderItems.Where(x => x.Id == rrItem.OrderItemId).First();

                    if (order.CustomerTaxDisplayType == TaxDisplayType.IncludingTax)
                    {
                        //including tax
                        total += orderItem.UnitPriceInclTax * rrItem.Quantity;
                    }
                    else
                    {
                        //excluding tax
                        total += orderItem.UnitPriceExclTax * rrItem.Quantity;
                    }
                }

                var itemModel = new CustomerReturnRequestsModel.ReturnRequestModel {
                    Id = returnRequest.Id,
                    ReturnNumber = returnRequest.ReturnNumber,
                    ReturnRequestStatus = returnRequest.ReturnRequestStatus.GetLocalizedEnum(_localizationService, request.Language.Id),
                    CreatedOn = _dateTimeHelper.ConvertToUserTime(returnRequest.CreatedOnUtc, DateTimeKind.Utc),
                    ProductsCount = returnRequest.ReturnRequestItems.Sum(x => x.Quantity),
                    ReturnTotal = _priceFormatter.FormatPrice(total)
                };

                model.Items.Add(itemModel);
            }

            return model;
        }
    }
}
