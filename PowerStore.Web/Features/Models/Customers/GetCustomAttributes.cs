using PowerStore.Domain.Common;
using PowerStore.Domain.Customers;
using PowerStore.Domain.Localization;
using PowerStore.Web.Models.Customer;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Customers
{
    public class GetCustomAttributes : IRequest<IList<CustomerAttributeModel>>
    {
        public Customer Customer { get; set; }
        public Language Language { get; set; }
        public IList<CustomAttribute> OverrideAttributes { get; set; }
    }
}
