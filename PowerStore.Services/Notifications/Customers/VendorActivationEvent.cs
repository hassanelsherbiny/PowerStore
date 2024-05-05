using PowerStore.Domain.Vendors;
using MediatR;

namespace PowerStore.Services.Notifications.Customers
{
    public class VendorActivationEvent : INotification
    {
        public VendorActivationEvent(Vendor vendor)
        {
            Vendor = vendor;
        }

        /// <summary>
        /// Vendor
        /// </summary>
        public Vendor Vendor {
            get; private set;
        }
    }
}
