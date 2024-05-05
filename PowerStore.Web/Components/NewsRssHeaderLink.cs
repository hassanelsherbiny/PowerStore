using PowerStore.Domain.News;
using PowerStore.Framework.Components;
using Microsoft.AspNetCore.Mvc;

namespace PowerStore.Web.ViewComponents
{
    public class NewsRssHeaderLinkViewComponent : BaseViewComponent
    {
        private readonly NewsSettings _newsSettings;
        public NewsRssHeaderLinkViewComponent(NewsSettings newsSettings)
        {
            _newsSettings = newsSettings;
        }

        public IViewComponentResult Invoke()
        {
            if (!_newsSettings.Enabled || !_newsSettings.ShowHeaderRssUrl)
                return Content("");

            return View();

        }
    }
}