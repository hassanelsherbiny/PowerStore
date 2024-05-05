using PowerStore.Domain.Customers;
using PowerStore.Domain.Directory;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Catalog;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Catalog
{
    public class GetSearchAutoComplete : IRequest<IList<SearchAutoCompleteModel>>
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public Language Language { get; set; }
        public Currency Currency { get; set; }
        public string Term { get; set; }
        public string CategoryId { get; set; }
    }
}
