using PowerStore.Core;
using PowerStore.Domain.Orders;
using PowerStore.Domain.Tax;
using PowerStore.Services.Catalog;
using PowerStore.Services.Directory;
using PowerStore.Services.Helpers;
using PowerStore.Services.Localization;
using PowerStore.Services.Orders;
using PowerStore.Services.Seo;
using PowerStore.Web.Features.Models.Common;
using PowerStore.Web.Features.Models.Orders;
using PowerStore.Web.Models.Orders;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Features.Handlers.Orders
{
    public class GetReturnRequestDetailsHandler : IRequestHandler<GetReturnRequestDetails, ReturnRequestDetailsModel>
    {
        private readonly IProductService _productService;
        private readonly ICurrencyService _currencyService;
        private readonly IReturnRequestService _returnRequestService;
        private readonly IPriceFormatter _priceFormatter;
        private readonly IWorkContext _workContext;
        private readonly IMediator _mediator;
        private readonly IDateTimeHelper _dateTimeHelper;
        private readonly OrderSettings _orderSettings;

        public GetReturnRequestDetailsHandler(
            IProductService productService,
            ICurrencyService currencyService,
            IReturnRequestService returnRequestService,
            IPriceFormatter priceFormatter,
            IWorkContext workContext,
            IMediator mediator,
            IDateTimeHelper dateTimeHelper,
            OrderSettings orderSettings)
        {
            _productService = productService;
            _currencyService = currencyService;
            _returnRequestService = returnRequestService;
            _priceFormatter = priceFormatter;
            _workContext = workContext;
            _mediator = mediator;
            _dateTimeHelper = dateTimeHelper;
            _orderSettings = orderSettings;
        }

        public async Task<ReturnRequestDetailsModel> Handle(GetReturnRequestDetails request, CancellationToken cancellationToken)
        {
            var model = new ReturnRequestDetailsModel();
            model.Comments = request.ReturnRequest.CustomerComments;
            model.ReturnNumber = request.ReturnRequest.ReturnNumber;
            model.ExternalId = request.ReturnRequest.ExternalId;
            model.ReturnRequestStatus = request.ReturnRequest.ReturnRequestStatus;
            model.CreatedOnUtc = request.ReturnRequest.CreatedOnUtc;
            model.ShowPickupAddress = _orderSettings.ReturnRequests_AllowToSpecifyPickupAddress;
            model.ShowPickupDate = _orderSettings.ReturnRequests_AllowToSpecifyPickupDate;
            model.PickupDate = request.ReturnRequest.PickupDate;
            model.GenericAttributes = request.ReturnRequest.GenericAttributes;
            model.PickupAddress = await _mediator.Send(new GetAddressModel() {
                Language = request.Language,
                Address = request.ReturnRequest.PickupAddress,
                ExcludeProperties = false,
            });

            foreach (var item in request.ReturnRequest.ReturnRequestItems)
            {
                var orderItem = request.Order.OrderItems.Where(x => x.Id == item.OrderItemId).FirstOrDefault();
                var product = await _productService.GetProductByIdIncludeArch(orderItem.ProductId);

                string unitPrice = string.Empty;
                if (request.Order.CustomerTaxDisplayType == TaxDisplayType.IncludingTax)
                {
                    //including tax
                    unitPrice = _priceFormatter.FormatPrice(orderItem.UnitPriceInclTax);
                }
                else
                {
                    //excluding tax
                    unitPrice = _priceFormatter.FormatPrice(orderItem.UnitPriceExclTax);
                }

                model.ReturnRequestItems.Add(new ReturnRequestDetailsModel.ReturnRequestItemModel {
                    OrderItemId = item.OrderItemId,
                    Quantity = item.Quantity,
                    ReasonForReturn = item.ReasonForReturn,
                    RequestedAction = item.RequestedAction,
                    ProductName = product.GetLocalized(x => x.Name, _workContext.WorkingLanguage.Id),
                    ProductSeName = product.GetSeName(_workContext.WorkingLanguage.Id),
                    ProductPrice = unitPrice
                });
            }

            //return request notes
            await PrepareReturnRequestNotes(request, model);

            return model;
        }

        private async Task PrepareReturnRequestNotes(GetReturnRequestDetails request, ReturnRequestDetailsModel model)
        {
            foreach (var returnRequestNote in (await _returnRequestService.GetReturnRequestNotes(request.ReturnRequest.Id))
                    .Where(rrn => rrn.DisplayToCustomer)
                    .OrderByDescending(rrn => rrn.CreatedOnUtc)
                    .ToList())
            {
                model.ReturnRequestNotes.Add(new ReturnRequestDetailsModel.ReturnRequestNote {
                    Id = returnRequestNote.Id,
                    ReturnRequestId = returnRequestNote.ReturnRequestId,
                    HasDownload = !String.IsNullOrEmpty(returnRequestNote.DownloadId),
                    Note = returnRequestNote.FormatReturnRequestNoteText(),
                    CreatedOn = _dateTimeHelper.ConvertToUserTime(returnRequestNote.CreatedOnUtc, DateTimeKind.Utc)
                });
            }
        }
    }
}
