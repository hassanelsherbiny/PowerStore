using PowerStore.Domain.News;
using PowerStore.Framework.Components;
using PowerStore.Web.Features.Models.News;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace PowerStore.Web.ViewComponents
{
    public class HomePageNewsViewComponent : BaseViewComponent
    {
        private readonly IMediator _mediator;
        private readonly NewsSettings _newsSettings;
        public HomePageNewsViewComponent(IMediator mediator,
            NewsSettings newsSettings)
        {
            _mediator = mediator;
            _newsSettings = newsSettings;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (!_newsSettings.Enabled || !_newsSettings.ShowNewsOnMainPage)
                return Content("");

            var model = await _mediator.Send(new GetHomePageNewsItems());
            if (!model.NewsItems.Any())
                return Content("");

            return View(model);
        }
    }
}