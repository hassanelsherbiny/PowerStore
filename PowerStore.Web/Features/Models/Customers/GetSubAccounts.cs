using PowerStore.Domain.Customers;
using PowerStore.Web.Models.Customer;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Customers
{
    public class GetSubAccounts : IRequest<IList<SubAccountSimpleModel>>
    {
        public Customer Customer { get; set; }
    }
}
