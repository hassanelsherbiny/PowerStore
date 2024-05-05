using PowerStore.Domain.Customers;
using PowerStore.Domain.Stores;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace PowerStore.Web.Commands.Models.Common
{
    public class ContactAttributeChangeCommand : IRequest<(IList<string> enabledAttributeIds, IList<string> disabledAttributeIds)>
    {
        public IFormCollection Form { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }

    }
}
