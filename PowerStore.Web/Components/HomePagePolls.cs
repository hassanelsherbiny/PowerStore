using PowerStore.Framework.Components;
using PowerStore.Web.Features.Models.Polls;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace PowerStore.Web.ViewComponents
{
    public class HomePagePollsViewComponent : BaseViewComponent
    {
        private readonly IMediator _mediator;

        public HomePagePollsViewComponent(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _mediator.Send(new GetHomePagePolls());
            if (!model.Any())
                Content("");

            return View(model);
        }
    }
}