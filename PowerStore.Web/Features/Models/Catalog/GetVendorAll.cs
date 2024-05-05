using PowerStore.Domain.Localization;
using PowerStore.Web.Models.Catalog;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Catalog
{
    public class GetVendorAll : IRequest<IList<VendorModel>>
    {
        public Language Language { get; set; }
    }
}
