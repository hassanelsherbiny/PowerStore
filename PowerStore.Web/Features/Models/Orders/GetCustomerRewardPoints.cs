using PowerStore.Domain.Customers;
using PowerStore.Domain.Directory;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Orders;
using MediatR;

namespace PowerStore.Web.Features.Models.Orders
{
    public class GetCustomerRewardPoints : IRequest<CustomerRewardPointsModel>
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public Currency Currency { get; set; }
    }
}
