using PowerStore.Domain.Customers;
using PowerStore.Web.Models.Customer;
using MediatR;

namespace PowerStore.Web.Features.Models.Customers
{
    public class GetNotes : IRequest<CustomerNotesModel>
    {
        public Customer Customer { get; set; }
    }
}
