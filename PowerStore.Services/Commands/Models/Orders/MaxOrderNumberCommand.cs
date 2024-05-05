using MediatR;

namespace PowerStore.Services.Commands.Models.Orders
{
    public class MaxOrderNumberCommand : IRequest<int?>
    {
        public int? OrderNumber { get; set; }
    }
}
