using PowerStore.Domain.Stores;
using PowerStore.Domain.Vendors;
using PowerStore.Web.Models.Common;
using MediatR;

namespace PowerStore.Web.Commands.Models.Vendors
{
    public class ContactVendorSendCommand : IRequest<ContactVendorModel>
    {
        public Vendor Vendor { get; set; }
        public Store Store { get; set; }
        public ContactVendorModel Model { get; set; }

    }
}
