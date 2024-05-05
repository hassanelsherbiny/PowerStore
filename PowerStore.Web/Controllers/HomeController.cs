using Microsoft.AspNetCore.Mvc;

namespace PowerStore.Web.Controllers
{
    public partial class HomeController : BasePublicController
    {
        public virtual IActionResult Index() => View();
    }
}
