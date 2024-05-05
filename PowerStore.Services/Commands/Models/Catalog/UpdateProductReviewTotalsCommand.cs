using PowerStore.Domain.Catalog;
using MediatR;

namespace PowerStore.Services.Commands.Models.Catalog
{
    public class UpdateProductReviewTotalsCommand : IRequest<bool>
    {
        public Product Product { get; set; }
    }
}
