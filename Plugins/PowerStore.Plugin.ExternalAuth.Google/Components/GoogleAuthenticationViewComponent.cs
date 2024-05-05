using Microsoft.AspNetCore.Mvc;

namespace PowerStore.Plugin.ExternalAuth.Google.Components
{
    [ViewComponent(Name = "GoogleAuthentication")]
    public class GoogleAuthenticationViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Plugins/ExternalAuth.Google/Views/PublicInfo.cshtml");
        }
    }
}