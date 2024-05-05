using PowerStore.Domain.Catalog;
using PowerStore.Domain.Orders;
using PowerStore.Domain.Tax;
using PowerStore.Services.Catalog;
using PowerStore.Services.Commands.Models.Orders;
using PowerStore.Services.Customers;
using PowerStore.Services.Orders;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Services.Commands.Handlers.Orders
{
    public class ReOrderCommandHandler : IRequestHandler<ReOrderCommand, IList<string>>
    {
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;
        private readonly IShoppingCartService _shoppingCartService;
        private readonly TaxSettings _taxSettings;

        public ReOrderCommandHandler(
            ICustomerService customerService, 
            IProductService productService, 
            IShoppingCartService shoppingCartService,
            TaxSettings taxSettings)
        {
            _customerService = customerService;
            _productService = productService;
            _shoppingCartService = shoppingCartService;
            _taxSettings = taxSettings;
        }

        public async Task<IList<string>> Handle(ReOrderCommand request, CancellationToken cancellationToken)
        {
            if (request.Order == null)
                throw new ArgumentNullException("order");

            var warnings = new List<string>();
            var customer = await _customerService.GetCustomerById(request.Order.CustomerId);

            foreach (var orderItem in request.Order.OrderItems)
            {
                var product = await _productService.GetProductById(orderItem.ProductId);
                if (product != null)
                {
                    if (product.ProductType == ProductType.SimpleProduct)
                    {
                        warnings.AddRange(await _shoppingCartService.AddToCart(customer, orderItem.ProductId,
                            ShoppingCartType.ShoppingCart, request.Order.StoreId, orderItem.WarehouseId,
                            orderItem.Attributes, 
                            product.CustomerEntersPrice ?
                            _taxSettings.PricesIncludeTax ? orderItem.UnitPriceInclTax : orderItem.UnitPriceExclTax
                            : (decimal?)default,
                            orderItem.RentalStartDateUtc, orderItem.RentalEndDateUtc,
                            orderItem.Quantity, false));
                    }
                }
                else
                {
                    warnings.Add("Product is not available");
                }
            }

            return warnings;
        }
    }
}
