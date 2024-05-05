using PowerStore.Core;
using PowerStore.Domain.Customers;
using PowerStore.Framework.Components;
using PowerStore.Services.Localization;
using PowerStore.Web.Models.Common;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PowerStore.Web.ViewComponents
{
    public class HeaderLinksViewComponent : BaseViewComponent
    {
        private readonly IWorkContext _workContext;
        private readonly IStoreContext _storeContext;
        private readonly ILocalizationService _localizationService;

        private readonly CustomerSettings _customerSettings;

        public HeaderLinksViewComponent(IWorkContext workContext,
            IStoreContext storeContext,
            ILocalizationService localizationService,
            CustomerSettings customerSettings)
        {
            _workContext = workContext;
            _storeContext = storeContext;
            _localizationService = localizationService;
            _customerSettings = customerSettings;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await PrepareHeaderLinks();
            return View(model);
        }
        private async Task<HeaderLinksModel> PrepareHeaderLinks()
        {
            var isRegister = _workContext.CurrentCustomer.IsRegistered();
            var model = new HeaderLinksModel {
                IsAuthenticated = isRegister,
                CustomerEmailUsername = isRegister ? (_customerSettings.UsernamesEnabled ? _workContext.CurrentCustomer.Username : _workContext.CurrentCustomer.Email) : "",
            };
            return await Task.FromResult(model);
        }
    }
}