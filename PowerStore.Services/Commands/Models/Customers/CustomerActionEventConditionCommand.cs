using PowerStore.Domain.Common;
using PowerStore.Domain.Customers;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Services.Commands.Models.Customers
{
    public class CustomerActionEventConditionCommand : IRequest<bool>
    {
        public CustomerActionEventConditionCommand()
        {
            CustomerActionTypes = new List<CustomerActionType>();
        }
        public IList<CustomerActionType> CustomerActionTypes { get; set; }
        public CustomerAction Action { get; set; }
        public string ProductId { get; set; }
        public IList<CustomAttribute> Attributes { get; set; } = new List<CustomAttribute>();
        public string CustomerId { get; set; }
        public string CurrentUrl { get; set; }
        public string PreviousUrl { get; set; }
    }
}
