using PowerStore.Domain.Catalog;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Orders;
using PowerStore.Services.Catalog;
using PowerStore.Services.Commands.Models.Catalog;
using PowerStore.Services.Customers;
using PowerStore.Services.Messages;
using PowerStore.Services.Queries.Models.Orders;
using PowerStore.Web.Commands.Models.Products;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Commands.Handler.Products
{
    public class InsertProductReviewCommandHandler : IRequestHandler<InsertProductReviewCommand, ProductReview>
    {
        private readonly IProductReviewService _productReviewService;
        private readonly ICustomerService _customerService;
        private readonly IWorkflowMessageService _workflowMessageService;
        private readonly IMediator _mediator;

        private readonly CatalogSettings _catalogSettings;
        private readonly LocalizationSettings _localizationSettings;

        public InsertProductReviewCommandHandler(
            IProductReviewService productReviewService,
            ICustomerService customerService,
            IWorkflowMessageService workflowMessageService,
            IMediator mediator,
            CatalogSettings catalogSettings,
            LocalizationSettings localizationSettings)
        {
            _productReviewService = productReviewService;
            _customerService = customerService;
            _workflowMessageService = workflowMessageService;
            _mediator = mediator;
            _catalogSettings = catalogSettings;
            _localizationSettings = localizationSettings;
        }

        public async Task<ProductReview> Handle(InsertProductReviewCommand request, CancellationToken cancellationToken)
        {
            //save review
            var rating = request.Model.AddProductReview.Rating;
            if (rating < 1 || rating > 5)
                rating = _catalogSettings.DefaultProductRatingValue;
            var isApproved = !_catalogSettings.ProductReviewsMustBeApproved;

            var confirmPurchased = _catalogSettings.ProductReviewPossibleOnlyAfterPurchasing ? true :
                (await _mediator.Send(new GetOrderQuery() {
                    CustomerId = request.Customer.Id,
                    StoreId = request.Store.Id,
                    ProductId = request.Product.Id,
                    Os = OrderStatus.Complete,
                    PageSize = 1
                })).Any();

            var productReview = new ProductReview {
                ProductId = request.Product.Id,
                StoreId = request.Store.Id,
                CustomerId = request.Customer.Id,
                Title = request.Model.AddProductReview.Title,
                ReviewText = request.Model.AddProductReview.ReviewText,
                Rating = rating,
                HelpfulYesTotal = 0,
                HelpfulNoTotal = 0,
                IsApproved = isApproved,
                ConfirmedPurchase = confirmPurchased,
                CreatedOnUtc = DateTime.UtcNow,
            };

            await _productReviewService.InsertProductReview(productReview);

            if (!request.Customer.HasContributions)
            {
                await _customerService.UpdateContributions(request.Customer);
            }

            //update product totals
            await _mediator.Send(new UpdateProductReviewTotalsCommand() { Product = request.Product });

            //notify store owner
            if (_catalogSettings.NotifyStoreOwnerAboutNewProductReviews)
                await _workflowMessageService.SendProductReviewNotificationMessage(request.Product, productReview, request.Store, _localizationSettings.DefaultAdminLanguageId);

            return productReview;
        }
    }
}
