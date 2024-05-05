using PowerStore.Domain.Localization;
using PowerStore.Domain.Orders;
using PowerStore.Web.Models.Orders;
using MediatR;

namespace PowerStore.Web.Commands.Models.Orders
{
    public class InsertOrderNoteCommand : IRequest<OrderNote>
    {
        public Order Order { get; set; } 
        public Language Language { get; set; }
        public AddOrderNoteModel OrderNote { get; set; }
    }
}
