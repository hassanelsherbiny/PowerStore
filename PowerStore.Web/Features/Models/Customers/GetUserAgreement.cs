using PowerStore.Web.Models.Customer;
using MediatR;
using System;

namespace PowerStore.Web.Features.Models.Customers
{
    public class GetUserAgreement : IRequest<UserAgreementModel>
    {
        public Guid OrderItemId { get; set; }
    }
}
