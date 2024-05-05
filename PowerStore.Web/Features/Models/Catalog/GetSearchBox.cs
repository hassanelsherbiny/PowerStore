using PowerStore.Domain.Customers;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Catalog;
using MediatR;

namespace PowerStore.Web.Features.Models.Catalog
{
    public class GetSearchBox : IRequest<SearchBoxModel>
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }
    }
}
