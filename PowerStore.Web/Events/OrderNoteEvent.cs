using PowerStore.Domain.Orders;
using PowerStore.Web.Models.Orders;
using MediatR;

namespace PowerStore.Web.Events
{
    public class OrderNoteEvent : INotification
    {
        public Order Order { get; private set; }
        public AddOrderNoteModel NoteModel { get; private set; }
        public OrderNoteEvent(Order order, AddOrderNoteModel noteModel)
        {
            Order = order;
            NoteModel = noteModel;
        }
    }
}
