using PowerStore.Domain.Customers;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Web.Models.Common;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace PowerStore.Web.Commands.Models.Common
{
    public class ContactUsCommand : IRequest<ContactUsModel>
    {
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public Language Language { get; set; }
        public ContactUsModel Model { get; set; }
        public IFormCollection Form { get; set; }
    }
}
