using PowerStore.Domain.Catalog;
using PowerStore.Domain.Directory;
using MediatR;
namespace PowerStore.Web.Features.Models.Catalog
{
    public class GetFormatBasePrice : IRequest<string>
    {
        public Currency Currency { get; set; }
        public Product Product { get; set; }
        public decimal? ProductPrice { get; set; }
    }
}
