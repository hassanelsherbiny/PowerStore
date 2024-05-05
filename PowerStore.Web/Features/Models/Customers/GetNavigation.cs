using PowerStore.Domain.Customers;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Domain.Vendors;
using PowerStore.Web.Models.Customer;
using MediatR;

namespace PowerStore.Web.Features.Models.Customers
{
    public class GetNavigation : IRequest<CustomerNavigationModel>
    {
        public int SelectedTabId { get; set; } = 0;
        public Customer Customer { get; set; }
        public Language Language { get; set; }
        public Store Store { get; set; }
        public Vendor Vendor { get; set; }
    }
}
