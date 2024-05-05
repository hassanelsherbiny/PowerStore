using PowerStore.Core;
using PowerStore.Core.Caching;
using PowerStore.Domain.Stores;
using PowerStore.Framework.Components;
using PowerStore.Framework.Themes;
using PowerStore.Services.Localization;
using PowerStore.Services.Media;
using PowerStore.Web.Infrastructure.Cache;
using PowerStore.Web.Models.Common;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PowerStore.Web.ViewComponents
{
    public class LogoViewComponent : BaseViewComponent
    {
        private readonly IStoreContext _storeContext;
        private readonly IWorkContext _workContext;
        private readonly ICacheBase _cacheBase;
        private readonly IPictureService _pictureService;
        private readonly IThemeContext _themeContext;

        private readonly StoreInformationSettings _storeInformationSettings;

        public LogoViewComponent(IStoreContext storeContext,
            IWorkContext workContext,
            ICacheBase cacheManager,
            IPictureService pictureService,
            IThemeContext themeContext,
            StoreInformationSettings storeInformationSettings)
        {
            _storeContext = storeContext;
            _workContext = workContext;
            _cacheBase = cacheManager;
            _pictureService = pictureService;
            _themeContext = themeContext;
            _storeInformationSettings = storeInformationSettings;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = await PrepareLogo();
            return View(model);
        }

        private async Task<LogoModel> PrepareLogo()
        {
            var model = new LogoModel {
                StoreName = _storeContext.CurrentStore.GetLocalized(x => x.Name, _workContext.WorkingLanguage.Id)
            };

            var cacheKey = string.Format(ModelCacheEventConst.STORE_LOGO_PATH, _storeContext.CurrentStore.Id, _themeContext.WorkingThemeName);
            model.LogoPath = await _cacheBase.GetAsync(cacheKey, async () =>
            {
                var logo = "";
                var picture = await _pictureService.GetPictureById(_storeInformationSettings.LogoPictureId);
                if (picture != null)
                {
                    logo = await _pictureService.GetPictureUrl(picture, showDefaultPicture: false);
                }
                if (string.IsNullOrEmpty(logo))
                {
                    //use default logo
                    logo = string.Format("{0}://{1}/Themes/{2}/Content/images/logo.png", HttpContext.Request.Scheme, HttpContext.Request.Host, _themeContext.WorkingThemeName);
                }
                return logo;
            });
            return model;
        }
    }
}