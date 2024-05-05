using PowerStore.Domain.Customers;
using PowerStore.Domain.Stores;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Catalog
{
    public class GetChildCategoryIds : IRequest<IList<string>>
    {
        public string ParentCategoryId { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }

    }
}
