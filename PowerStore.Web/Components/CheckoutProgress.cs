using PowerStore.Framework.Components;
using PowerStore.Web.Models.Checkout;
using Microsoft.AspNetCore.Mvc;

namespace PowerStore.Web.ViewComponents
{
    public class CheckoutProgressViewComponent : BaseViewComponent
    {
        public IViewComponentResult Invoke(CheckoutProgressStep step)
        {
            var model = new CheckoutProgressModel { CheckoutProgressStep = step };
            return View(model);

        }
    }
}