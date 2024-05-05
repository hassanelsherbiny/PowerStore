using PowerStore.Domain.Customers;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PowerStore.Web.Features.Models.Common
{
    public class GetSitemapXml : IRequest<string>
    {
        public int? Id { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public Language Language { get; set; }
        public IUrlHelper UrlHelper { get; set; }
    }
}
