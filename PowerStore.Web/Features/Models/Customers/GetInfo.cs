using PowerStore.Domain.Common;
using PowerStore.Domain.Customers;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Customer;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Customers
{
    public class GetInfo : IRequest<CustomerInfoModel>
    {
        public CustomerInfoModel Model { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public Language Language { get; set; }
        public bool ExcludeProperties { get; set; }
        public IList<CustomAttribute> OverrideCustomCustomerAttributes { get; set; }
    }
}
