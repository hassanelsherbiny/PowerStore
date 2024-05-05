using MediatR;

namespace PowerStore.Services.Commands.Models.Customers
{
    public class UpdateCustomerReminderHistoryCommand : IRequest<bool>
    {
        public string CustomerId { get; set; }
        public string OrderId { get; set; }
    }
}
