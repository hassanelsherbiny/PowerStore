using PowerStore.Domain.Customers;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Common;
using MediatR;

namespace PowerStore.Web.Features.Models.Common
{
    public class GetSitemap : IRequest<SitemapModel>
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public Language Language { get; set; }
    }
}
