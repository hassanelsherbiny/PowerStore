using PowerStore.Domain.Orders;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Services.Commands.Models.Orders
{
    public class CancelRecurringPaymentCommand : IRequest<IList<string>>
    {
        public RecurringPayment RecurringPayment { get; set; }
    }
}
