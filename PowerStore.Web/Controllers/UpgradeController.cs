using PowerStore.Core;
using PowerStore.Core.Data;
using PowerStore.Services.Installation;
using PowerStore.Web.Models.Upgrade;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PowerStore.Web.Controllers
{
    public partial class UpgradeController : BasePublicController
    {
        #region Fields

        private readonly IUpgradeService _upgradeService;

        #endregion

        #region Ctor

        public UpgradeController(IUpgradeService upgradeService)
        {
            _upgradeService = upgradeService;
        }
        #endregion

        public virtual IActionResult Index()
        {
            if (!DataSettingsHelper.DatabaseIsInstalled())
                return RedirectToRoute("Install");

            var model = new UpgradeModel {
                ApplicationVersion = PowerStoreVersion.FullVersion,
                ApplicationDBVersion = PowerStoreVersion.SupportedDBVersion,
                DatabaseVersion = _upgradeService.DatabaseVersion()
            };

            if (model.ApplicationDBVersion == model.DatabaseVersion)
                return RedirectToRoute("Homepage");

            return View(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Index(UpgradeModel m, [FromServices] IWebHelper webHelper)
        {
            var model = new UpgradeModel {
                ApplicationDBVersion = PowerStoreVersion.SupportedDBVersion,
                DatabaseVersion = _upgradeService.DatabaseVersion()
            };

            if (model.ApplicationDBVersion != model.DatabaseVersion)
            {
                await _upgradeService.UpgradeData(model.DatabaseVersion, model.ApplicationDBVersion);
            }
            else
                return RedirectToRoute("HomePage");

            //restart application
            webHelper.StopApplication();

            //Redirect to home page
            return RedirectToRoute("HomePage");

        }
    }
}