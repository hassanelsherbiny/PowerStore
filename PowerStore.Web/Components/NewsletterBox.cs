using PowerStore.Framework.Components;
using PowerStore.Web.Features.Models.Newsletter;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PowerStore.Web.ViewComponents
{
    public class NewsletterBoxViewComponent : BaseViewComponent
    {
        private readonly IMediator _mediator;

        public NewsletterBoxViewComponent(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _mediator.Send(new GetNewsletterBox());
            if (model == null)
                return Content("");

            return View(model);
        }
    }
}