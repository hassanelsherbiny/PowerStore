using PowerStore.Core;
using PowerStore.Domain.Orders;
using PowerStore.Framework.Components;
using PowerStore.Services.Security;
using PowerStore.Web.Features.Models.ShoppingCart;
using PowerStore.Web.Models.ShoppingCart;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PowerStore.Web.ViewComponents
{
    public class FlyoutShoppingCartViewComponent : BaseViewComponent
    {
        private readonly IMediator _mediator;
        private readonly IPermissionService _permissionService;
        private readonly ShoppingCartSettings _shoppingCartSettings;
        private readonly IWorkContext _workContext;
        private readonly IStoreContext _storeContext;

        public FlyoutShoppingCartViewComponent(IMediator mediator,
            IPermissionService permissionService,
            ShoppingCartSettings shoppingCartSettings,
            IWorkContext workContext,
            IStoreContext storeContext)
        {
            _mediator = mediator;
            _permissionService = permissionService;
            _shoppingCartSettings = shoppingCartSettings;
            _workContext = workContext;
            _storeContext = storeContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(MiniShoppingCartModel model)
        {
            if (!_shoppingCartSettings.MiniShoppingCartEnabled)
                return Content("");

            if (!await _permissionService.Authorize(StandardPermissionProvider.EnableShoppingCart))
                return Content("");

            model ??=  await _mediator.Send(new GetMiniShoppingCart() {
                Customer = _workContext.CurrentCustomer,
                Currency = _workContext.WorkingCurrency,
                Language = _workContext.WorkingLanguage,
                TaxDisplayType = _workContext.TaxDisplayType,
                Store = _storeContext.CurrentStore
            });
            return View(model);
        }
    }
}