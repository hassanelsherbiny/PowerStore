using PowerStore.Core;
using PowerStore.Framework.Components;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Extensions;
using PowerStore.Web.Areas.Admin.Models.Common;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace PowerStore.Web.Areas.Admin.Components
{
    public class CommonLanguageSelectorViewComponent : BaseAdminViewComponent
    {
        private readonly IWorkContext _workContext;
        private readonly ILanguageService _languageService;
        private readonly IStoreContext _storeContext;

        public CommonLanguageSelectorViewComponent(
            IWorkContext workContext,
            ILanguageService languageService, 
            IStoreContext storeContext
            )
        {
            _workContext = workContext;
            _languageService = languageService;
            _storeContext = storeContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new LanguageSelectorModel();
            model.CurrentLanguage = _workContext.WorkingLanguage.ToModel();
            model.AvailableLanguages = (await _languageService
                .GetAllLanguages(storeId: _storeContext.CurrentStore.Id))
                .Select(x => x.ToModel())
                .ToList();
            return View(model);
        }
    }
}