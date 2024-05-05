using PowerStore.Domain.Customers;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Catalog;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Catalog
{
    public class GetManufacturerFeaturedProducts : IRequest<IList<ManufacturerModel>>
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public Language Language { get; set; }
    }
}
