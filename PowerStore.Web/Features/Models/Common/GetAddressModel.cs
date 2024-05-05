using PowerStore.Domain.Common;
using PowerStore.Domain.Customers;
using PowerStore.Domain.Directory;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Common;
using MediatR;
using System;
using System.Collections.Generic;
namespace PowerStore.Web.Features.Models.Common
{
    public class GetAddressModel : IRequest<AddressModel>
    {
        public AddressModel Model { get; set; }
        public Address Address { get; set; }
        public bool ExcludeProperties { get; set; }
        public Func<IList<Country>> LoadCountries { get; set; } = null;
        public bool PrePopulateWithCustomerFields { get; set; } = false;
        public Customer Customer { get; set; } = null;
        public Language Language { get; set; }
        public Store Store { get; set; }
        public IList<CustomAttribute> OverrideAttributes { get; set; }
    }
}
