using PowerStore.Domain.Customers;
using PowerStore.Services.Authentication.External;
using MediatR;

namespace PowerStore.Services.Notifications.Authentication
{
    /// <summary>
    /// Customer auto registered by external authentication method event
    /// </summary>
    public class CustomerAutoRegisteredByExternalMethodEvent : INotification
    {
        public CustomerAutoRegisteredByExternalMethodEvent(Customer customer, ExternalAuthenticationParameters parameters)
        {
            Customer = customer;
            AuthenticationParameters = parameters;
        }

        /// <summary>
        /// Gets or sets customer
        /// </summary>
        public Customer Customer { get; private set; }

        /// <summary>
        /// Gets or sets external authentication parameters
        /// </summary>
        public ExternalAuthenticationParameters AuthenticationParameters { get; private set; }
    }
}
