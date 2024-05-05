using PowerStore.Domain.Customers;
using PowerStore.Web.Models.Customer;
using MediatR;

namespace PowerStore.Web.Features.Models.Customers
{
    public class GetSubAccount : IRequest<SubAccountModel>
    {
        public Customer CurrentCustomer { get; set; }
        public string CustomerId { get; set; }
    }
}
