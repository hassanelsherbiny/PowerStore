using PowerStore.Domain.Catalog;
using MediatR;

namespace PowerStore.Services.Queries.Models.Catalog
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public string Id { get; set; }
    }
}
