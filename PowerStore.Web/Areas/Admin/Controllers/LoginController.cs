using PowerStore.Core;
using PowerStore.Domain.Customers;
using PowerStore.Framework.Controllers;
using PowerStore.Framework.Mvc.Filters;
using PowerStore.Framework.Security.Captcha;
using PowerStore.Services.Authentication;
using PowerStore.Services.Common;
using PowerStore.Services.Customers;
using PowerStore.Services.Localization;
using PowerStore.Services.Notifications.Customers;
using PowerStore.Web.Areas.Admin.Extensions;
using PowerStore.Web.Areas.Admin.Models.Common;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Threading.Tasks;

namespace PowerStore.Web.Areas.Admin.Controllers
{
    [Area(Constants.AreaAdmin)]
    public class LoginController : BaseController
    {
        private readonly CustomerSettings _customerSettings;
        private readonly CaptchaSettings _captchaSettings;
        private readonly ILocalizationService _localizationService;
        private readonly ICustomerRegistrationService _customerRegistrationService;
        private readonly ICustomerService _customerService;
        private readonly IPowerStoreAuthenticationService _authenticationService;
        private readonly IWorkContext _workContext;
        private readonly IMediator _mediator;

        public LoginController(CustomerSettings customerSettings, CaptchaSettings captchaSettings,
            ILocalizationService localizationService, ICustomerRegistrationService customerRegistrationService,
            ICustomerService customerService, IPowerStoreAuthenticationService authenticationService,
            IWorkContext workContext,
            IMediator mediator)
        {
            _customerSettings = customerSettings;
            _captchaSettings = captchaSettings;
            _localizationService = localizationService;
            _customerRegistrationService = customerRegistrationService;
            _customerService = customerService;
            _authenticationService = authenticationService;
            _workContext = workContext;
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            var model = new LoginModel();
            model.UsernamesEnabled = _customerSettings.UsernamesEnabled;
            model.DisplayCaptcha = _captchaSettings.Enabled && _captchaSettings.ShowOnLoginPage;
            return View(model);
        }

        [HttpPost]
        [ValidateCaptcha]
        [AutoValidateAntiforgeryToken]
        public virtual async Task<IActionResult> Index(LoginModel model, bool captchaValid)
        {
            //validate CAPTCHA
            if (_captchaSettings.Enabled && _captchaSettings.ShowOnLoginPage && !captchaValid)
            {
                ModelState.AddModelError("", _captchaSettings.GetWrongCaptchaMessage(_localizationService));
            }

            if (ModelState.IsValid)
            {
                if (_customerSettings.UsernamesEnabled && model.Username != null)
                {
                    model.Username = model.Username.Trim();
                }
                var loginResult = await _customerRegistrationService.ValidateCustomer(_customerSettings.UsernamesEnabled ? model.Username : model.Email, model.Password);
                switch (loginResult)
                {
                    case CustomerLoginResults.Successful:
                        {
                            var customer = _customerSettings.UsernamesEnabled ? await _customerService.GetCustomerByUsername(model.Username) : await _customerService.GetCustomerByEmail(model.Email);
                            //sign in
                            return await SignInAction(customer, model.RememberMe);
                        }
                    case CustomerLoginResults.RequiresTwoFactor:
                        {
                            var userName = _customerSettings.UsernamesEnabled ? model.Username : model.Email;

                            HttpContext.Session.SetString("AdminRequiresTwoFactor", userName);

                            return RedirectToAction("TwoFactorAuthorization");
                        }

                    case CustomerLoginResults.CustomerNotExist:
                        ModelState.AddModelError("", _localizationService.GetResource("Account.Login.WrongCredentials.CustomerNotExist"));
                        break;
                    case CustomerLoginResults.Deleted:
                        ModelState.AddModelError("", _localizationService.GetResource("Account.Login.WrongCredentials.Deleted"));
                        break;
                    case CustomerLoginResults.NotActive:
                        ModelState.AddModelError("", _localizationService.GetResource("Account.Login.WrongCredentials.NotActive"));
                        break;
                    case CustomerLoginResults.NotRegistered:
                        ModelState.AddModelError("", _localizationService.GetResource("Account.Login.WrongCredentials.NotRegistered"));
                        break;
                    case CustomerLoginResults.LockedOut:
                        ModelState.AddModelError("", _localizationService.GetResource("Account.Login.WrongCredentials.LockedOut"));
                        break;
                    case CustomerLoginResults.WrongPassword:
                        ModelState.AddModelError("", _localizationService.GetResource("Account.Login.WrongCredentials"));
                        break;
                    default:
                        ModelState.AddModelError("", _localizationService.GetResource("Account.Login.WrongCredentials"));
                        break;
                }
            }

            //If we got this far, something failed, redisplay form
            model.UsernamesEnabled = _customerSettings.UsernamesEnabled;
            model.DisplayCaptcha = _captchaSettings.Enabled && _captchaSettings.ShowOnLoginPage;

            return View(model);
        }
        protected async Task<IActionResult> SignInAction(Customer customer, bool createPersistent)
        {
            //sign in new customer
            await _authenticationService.SignIn(customer, createPersistent);

            //raise event       
            await _mediator.Publish(new CustomerLoggedInEvent(customer));

            return RedirectToRoute("AdminIndex", new RouteValueDictionary());
        }

        public async Task<IActionResult> TwoFactorAuthorization([FromServices] ITwoFactorAuthenticationService twoFactorAuthenticationService)
        {
            if (!_customerSettings.TwoFactorAuthenticationEnabled)
                return RedirectToRoute("AdminLogin");

            var username = HttpContext.Session.GetString("AdminRequiresTwoFactor");
            if (string.IsNullOrEmpty(username))
                return RedirectToRoute("AdminLogin");

            var customer = _customerSettings.UsernamesEnabled ? await _customerService.GetCustomerByUsername(username) : await _customerService.GetCustomerByEmail(username);
            if (customer == null)
                return RedirectToRoute("AdminLogin");

            if (!customer.GetAttributeFromEntity<bool>(SystemCustomerAttributeNames.TwoFactorEnabled))
                return RedirectToRoute("AdminLogin");

            if (_customerSettings.TwoFactorAuthenticationType != TwoFactorAuthenticationType.AppVerification)
            {
                await twoFactorAuthenticationService.GenerateCodeSetup("", customer, _workContext.WorkingLanguage, _customerSettings.TwoFactorAuthenticationType);
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> TwoFactorAuthorization(string token,
            [FromServices] ITwoFactorAuthenticationService twoFactorAuthenticationService
            )
        {
            if (!_customerSettings.TwoFactorAuthenticationEnabled)
                return RedirectToRoute("AdminLogin");

            var username = HttpContext.Session.GetString("AdminRequiresTwoFactor");
            if (string.IsNullOrEmpty(username))
                return RedirectToRoute("HomePage");

            var customer = _customerSettings.UsernamesEnabled ? await _customerService.GetCustomerByUsername(username) : await _customerService.GetCustomerByEmail(username);
            if (customer == null)
                return RedirectToRoute("AdminLogin");

            if (string.IsNullOrEmpty(token))
            {
                ModelState.AddModelError("", _localizationService.GetResource("Account.TwoFactorAuth.SecurityCodeIsRequired"));
            }
            else
            {
                var secretKey = customer.GetAttributeFromEntity<string>(SystemCustomerAttributeNames.TwoFactorSecretKey);
                if (await twoFactorAuthenticationService.AuthenticateTwoFactor(secretKey, token, customer, _customerSettings.TwoFactorAuthenticationType))
                {
                    //remove session
                    HttpContext.Session.Remove("AdminRequiresTwoFactor");

                    //sign in
                    return await SignInAction(customer, false);
                }
                ModelState.AddModelError("", _localizationService.GetResource("Account.TwoFactorAuth.WrongSecurityCode"));
            }

            return View();
        }
    }
}
