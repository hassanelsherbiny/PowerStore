using PowerStore.Framework.Components;
using PowerStore.Services.Security;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PowerStore.Web.Areas.Admin.Components
{
    public class OrderOrderIncompleteReportViewComponent : BaseAdminViewComponent
    {
        private readonly IPermissionService _permissionService;

        public OrderOrderIncompleteReportViewComponent(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (!await _permissionService.Authorize(StandardPermissionProvider.ManageOrders))
                return Content("");

            return View();
        }
    }
}