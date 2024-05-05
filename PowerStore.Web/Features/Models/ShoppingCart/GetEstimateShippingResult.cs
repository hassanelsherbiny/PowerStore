using PowerStore.Domain.Customers;
using PowerStore.Domain.Directory;
using PowerStore.Domain.Orders;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.ShoppingCart;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.ShoppingCart
{
    public class GetEstimateShippingResult : IRequest<EstimateShippingResultModel>
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public Currency Currency { get; set; }

        public IList<ShoppingCartItem> Cart { get; set; }
        public string CountryId { get; set; }
        public string StateProvinceId { get; set; }
        public string ZipPostalCode { get; set; }
    }
}
