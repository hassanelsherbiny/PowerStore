using PowerStore.Domain.Common;
using PowerStore.Domain.Customers;
using PowerStore.Domain.Directory;
using PowerStore.Domain.Localization;
using PowerStore.Web.Models.Vendors;
using MediatR;
using System;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Common
{
    public class GetVendorAddress : IRequest<VendorAddressModel>
    {
        public VendorAddressModel Model { get; set; }
        public Address Address { get; set; }
        public bool ExcludeProperties { get; set; }
        public Func<IList<Country>> LoadCountries { get; set; } = null;
        public bool PrePopulateWithCustomerFields { get; set; } = false;
        public Customer Customer { get; set; } = null;
        public Language Language { get; set; }
    }
}
