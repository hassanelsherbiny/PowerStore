using PowerStore.Domain.Catalog;
using PowerStore.Domain.Orders;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Catalog;
using MediatR;

namespace PowerStore.Web.Features.Models.Products
{
    public class GetProductDetailsPage : IRequest<ProductDetailsModel>
    {
        public Store Store { get; set; }
        public Product Product { get; set; }
        public ShoppingCartItem UpdateCartItem { get; set; } = null;
        public bool IsAssociatedProduct { get; set; } = false;
    }
}
