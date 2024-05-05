using PowerStore.Domain.Customers;
using PowerStore.Domain.Orders;
using PowerStore.Domain.Stores;
using PowerStore.Domain.Vendors;
using PowerStore.Services.Messages.DotLiquidDrops;
using MediatR;

namespace PowerStore.Services.Commands.Models.Messages
{
    public class GetOrderTokensCommand : IRequest<LiquidOrder>
    {
        public Order Order { get; set; }
        public Customer Customer { get; set; }
        public Store Store { get; set; }
        public OrderNote OrderNote { get; set; } = null;
        public Vendor Vendor { get; set; } = null;
        public decimal RefundedAmount { get; set; } = 0;
    }
}
