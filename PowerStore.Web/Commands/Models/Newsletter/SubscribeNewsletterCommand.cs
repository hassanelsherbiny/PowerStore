using PowerStore.Web.Models.Newsletter;
using MediatR;

namespace PowerStore.Web.Commands.Models.Newsletter
{
    public class SubscribeNewsletterCommand : IRequest<SubscribeNewsletterResultModel>
    {
        public string Email { get; set; }
        public bool Subscribe { get; set; }
    }
}
