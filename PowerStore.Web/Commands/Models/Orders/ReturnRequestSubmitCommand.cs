using PowerStore.Domain.Common;
using PowerStore.Domain.Orders;
using PowerStore.Web.Models.Orders;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace PowerStore.Web.Commands.Models.Orders
{
    public class ReturnRequestSubmitCommand : IRequest<(ReturnRequestModel model, ReturnRequest rr)>
    {
        public ReturnRequestModel Model { get; set; }
        public Order Order { get; set; }
        public Address Address { get; set; }
        public IFormCollection Form { get; set; }
    }
}
