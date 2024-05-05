using PowerStore.Domain.Orders;
using PowerStore.Services.Messages;
using PowerStore.Services.Orders;
using PowerStore.Web.Commands.Models.Orders;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Commands.Handler.Orders
{
    public class InsertOrderNoteCommandHandler : IRequestHandler<InsertOrderNoteCommand, OrderNote>
    {
        private readonly IWorkflowMessageService _workflowMessageService;
        private readonly IOrderService _orderService;

        public InsertOrderNoteCommandHandler(IWorkflowMessageService workflowMessageService, IOrderService orderService)
        {
            _workflowMessageService = workflowMessageService;
            _orderService = orderService;
        }

        public async Task<OrderNote> Handle(InsertOrderNoteCommand request, CancellationToken cancellationToken)
        {
            var orderNote = new OrderNote {
                CreatedOnUtc = DateTime.UtcNow,
                DisplayToCustomer = true,
                Note = request.OrderNote.Note,
                OrderId = request.OrderNote.OrderId,
                CreatedByCustomer = true
            };
            await _orderService.InsertOrderNote(orderNote);

            //email
            await _workflowMessageService.SendNewOrderNoteAddedCustomerNotification(request.Order, orderNote);

            return orderNote;
        }
    }
}
