using PowerStore.Domain.Catalog;
using PowerStore.Domain.Common;
using PowerStore.Domain.Customers;
using PowerStore.Domain.Directory;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Orders;
using PowerStore.Domain.Stores;
using PowerStore.Domain.Tax;
using PowerStore.Web.Models.ShoppingCart;
using MediatR;
using System;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.ShoppingCart
{
    public class GetAddToCart : IRequest<AddToCartModel>
    {
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public Language Language { get; set; }
        public Currency Currency { get; set; }
        public Store Store { get; set; }
        public TaxDisplayType TaxDisplayType { get; set; }
        public int Quantity { get; set; }
        public decimal? CustomerEnteredPrice { get; set; }
        public IList<CustomAttribute> Attributes { get; set; } = new List<CustomAttribute>();
        public ShoppingCartType CartType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ReservationId { get; set; }
        public string Parameter { get; set; }
        public string Duration { get; set; }
    }
}
