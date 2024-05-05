using PowerStore.Domain.Customers;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Customer;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace PowerStore.Web.Commands.Models.Customers
{
    public class SubAccountEditCommand : IRequest<(bool success, string error)>
    {
        public Customer CurrentCustomer { get; set; }
        public Store Store { get; set; }
        public SubAccountModel Model { get; set; }
        public IFormCollection Form { get; set; }
    }
}
