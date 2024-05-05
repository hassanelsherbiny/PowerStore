using PowerStore.Domain.Customers;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Common;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Common
{
    public class GetPrivacyPreference : IRequest<IList<PrivacyPreferenceModel>>
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }
    }
}
