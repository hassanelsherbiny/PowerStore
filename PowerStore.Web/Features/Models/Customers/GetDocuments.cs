using PowerStore.Domain.Customers;
using PowerStore.Domain.Localization;
using PowerStore.Web.Models.Customer;
using MediatR;

namespace PowerStore.Web.Features.Models.Customers
{
    public class GetDocuments : IRequest<DocumentsModel>
    {
        public GetDocuments()
        {
            Command = new DocumentPagingModel();
        }
        public Customer Customer { get; set; }
        public Language Language { get; set; }
        public DocumentPagingModel Command { get; set; }
    }
}
