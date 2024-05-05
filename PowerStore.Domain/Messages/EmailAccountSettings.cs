using PowerStore.Domain.Configuration;

namespace PowerStore.Domain.Messages
{
    public class EmailAccountSettings : ISettings
    {
        /// <summary>
        /// Gets or sets a store default email account identifier
        /// </summary>
        public string DefaultEmailAccountId { get; set; }

    }

}
