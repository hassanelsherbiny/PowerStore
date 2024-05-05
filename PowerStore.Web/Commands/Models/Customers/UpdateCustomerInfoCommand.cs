using PowerStore.Domain.Common;
using PowerStore.Domain.Customers;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Customer;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace PowerStore.Web.Commands.Models.Customers
{
    public class UpdateCustomerInfoCommand : IRequest<bool>
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public CustomerInfoModel Model { get; set; }
        public IFormCollection Form { get; set; }
        public IList<CustomAttribute> CustomerAttributes { get; set; }
        public Customer OriginalCustomerIfImpersonated { get; set; }
    }
}
