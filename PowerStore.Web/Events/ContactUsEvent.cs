using PowerStore.Domain.Customers;
using PowerStore.Web.Models.Common;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace PowerStore.Web.Events
{
    public class ContactUsEvent : INotification
    {
        public Customer Customer { get; private set; }
        public ContactUsModel Model { get; private set; }
        public IFormCollection Form { get; private set; }

        public ContactUsEvent(Customer customer, ContactUsModel model, IFormCollection form)
        {
            Customer = customer;
            Model = model;
            Form = form;
        }
    }
}
