using PowerStore.Domain.Blogs;
using PowerStore.Framework.Components;
using PowerStore.Web.Features.Models.Blogs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PowerStore.Web.ViewComponents
{
    public class HomePageBlogViewComponent : BaseViewComponent
    {
        private readonly IMediator _mediator;
        private readonly BlogSettings _blogSettings;
        public HomePageBlogViewComponent(IMediator mediator,
            BlogSettings blogSettings)
        {
            _mediator = mediator;
            _blogSettings = blogSettings;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (!_blogSettings.Enabled || !_blogSettings.ShowBlogOnHomePage)
                return Content("");

            var model = await _mediator.Send(new GetHomePageBlog());
            return View(model);
        }
    }
}