using PowerStore.Domain.Orders;
using MediatR;
namespace PowerStore.Services.Commands.Models.Orders
{
    public class ReturnBackRedeemedRewardPointsCommand : IRequest<bool>
    {
        public Order Order { get; set; }
    }
}
