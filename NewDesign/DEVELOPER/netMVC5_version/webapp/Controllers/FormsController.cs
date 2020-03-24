#region Using

using System.Web.Mvc;

#endregion

namespace SmartAdminMvc.Controllers
{
    [Authorize]
    public class FormsController : Controller
    {
        // GET: /forms/smart-elements/
        public ActionResult SmartElements()
        {
            return View();
        }

        // GET: /forms/templates/
        public ActionResult Templates()
        {
            return View();
        }

        // GET: /forms/validation/
        public ActionResult Validation()
        {
            return View();
        }

        // GET: /forms/bootstrap/
        public ActionResult Bootstrap()
        {
            return View();
        }

        // GET: /forms/plugins/
        public ActionResult Plugins()
        {
            return View();
        }

        // GET: /forms/wizard/
        public ActionResult Wizards()
        {
            return View();
        }

        // GET: /forms/editors/
        public ActionResult Editors()
        {
            return View();
        }

        // GET: /forms/dropzone/
        public ActionResult Dropzone()
        {
            return View();
        }

        // GET: /forms/cropping/
        public ActionResult Cropping()
        {
            return View();
        }
    }
}