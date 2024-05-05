using PowerStore.Domain.Customers;
using MediatR;
namespace PowerStore.Services.Queries.Models.Customers
{
    public class GetCustomerByIdQuery : IRequest<Customer>
    {
        public string Id { get; set; }
    }
}
