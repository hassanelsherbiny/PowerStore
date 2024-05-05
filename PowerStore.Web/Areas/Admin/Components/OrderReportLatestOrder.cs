using PowerStore.Core;
using PowerStore.Framework.Components;
using PowerStore.Services.Security;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PowerStore.Web.Areas.Admin.Components
{
    public class OrderReportLatestOrderViewComponent : BaseAdminViewComponent
    {
        private readonly IPermissionService _permissionService;
        private readonly IWorkContext _workContext;

        public OrderReportLatestOrderViewComponent(IPermissionService permissionService, IWorkContext workContext)
        {
            _permissionService = permissionService;
            _workContext = workContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (!await _permissionService.Authorize(StandardPermissionProvider.ManageOrders))
                return Content("");

            var isLoggedInAsVendor = _workContext.CurrentVendor != null;
            return View(isLoggedInAsVendor);
        }
    }
}