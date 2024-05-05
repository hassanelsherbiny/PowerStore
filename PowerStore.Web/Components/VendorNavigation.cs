using PowerStore.Core;
using PowerStore.Domain.Vendors;
using PowerStore.Framework.Components;
using PowerStore.Web.Features.Models.Catalog;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace PowerStore.Web.ViewComponents
{
    public class VendorNavigationViewComponent : BaseViewComponent
    {
        private readonly IWorkContext _workContext;
        private readonly IMediator _mediator;
        private readonly VendorSettings _vendorSettings;

        public VendorNavigationViewComponent(
            IWorkContext workContext,
            IMediator mediator,
            VendorSettings vendorSettings)
        {
            _workContext = workContext;
            _mediator = mediator;
            _vendorSettings = vendorSettings;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (_vendorSettings.VendorsBlockItemsToDisplay == 0)
                return Content("");

            var model = await _mediator.Send(new GetVendorNavigation() {
                Language = _workContext.WorkingLanguage
            });

            if (!model.Vendors.Any())
                return Content("");

            return View(model);
        }
    }
}