using PowerStore.Core;
using PowerStore.Framework.Components;
using PowerStore.Web.Features.Models.Catalog;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PowerStore.Web.ViewComponents
{
    public class CategoryNavigationViewComponent : BaseViewComponent
    {
        private readonly IMediator _mediator;
        private readonly IWorkContext _workContext;
        private readonly IStoreContext _storeContext;

        public CategoryNavigationViewComponent(
            IMediator mediator,
            IWorkContext workContext,
            IStoreContext storeContext)
        {
            _mediator = mediator;
            _workContext = workContext;
            _storeContext = storeContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(string currentCategoryId, string currentProductId)
        {
            var model = await _mediator.Send(new GetCategoryNavigation() {
                Customer = _workContext.CurrentCustomer,
                Language = _workContext.WorkingLanguage,
                Store = _storeContext.CurrentStore,
                CurrentCategoryId = currentCategoryId,
                CurrentProductId = currentProductId
            });
            return View(model);
        }
    }
}