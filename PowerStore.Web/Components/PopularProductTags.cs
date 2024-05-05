using PowerStore.Core;
using PowerStore.Framework.Components;
using PowerStore.Web.Features.Models.Catalog;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace PowerStore.Web.ViewComponents
{
    public class PopularProductTagsViewComponent : BaseViewComponent
    {
        private readonly IMediator _mediator;
        private readonly IWorkContext _workContext;
        private readonly IStoreContext _storeContext;

        public PopularProductTagsViewComponent(IMediator mediator, IWorkContext workContext, IStoreContext storeContext)
        {
            _mediator = mediator;
            _workContext = workContext;
            _storeContext = storeContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await _mediator.Send(new GetPopularProductTags() {
                Language = _workContext.WorkingLanguage,
                Store = _storeContext.CurrentStore
            });
            if (!model.Tags.Any())
                return Content("");

            return View(model);

        }
    }
}