using PowerStore.Framework.Components;
using PowerStore.Services.Security;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PowerStore.Web.Areas.Admin.Components
{
    public class OrderBestsellersBriefReportByQuantityViewComponent : BaseAdminViewComponent
    {
        private readonly IPermissionService _permissionService;

        public OrderBestsellersBriefReportByQuantityViewComponent(IPermissionService permissionService)
        {
            this._permissionService = permissionService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (!await _permissionService.Authorize(StandardPermissionProvider.ManageOrders))
                return Content("");

            return View();
        }
    }
}