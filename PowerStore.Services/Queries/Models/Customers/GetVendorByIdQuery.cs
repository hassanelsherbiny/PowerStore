using PowerStore.Domain.Vendors;
using MediatR;
namespace PowerStore.Services.Queries.Models.Customers
{
    public class GetVendorByIdQuery : IRequest<Vendor>
    {
        public string Id { get; set; }
    }
}
