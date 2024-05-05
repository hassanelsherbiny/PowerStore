using PowerStore.Core;
using PowerStore.Framework.Controllers;
using PowerStore.Framework.Mvc.Filters;
using PowerStore.Framework.Security;
using PowerStore.Plugin.ExternalAuth.Facebook.Models;
using PowerStore.Services.Authentication.External;
using PowerStore.Services.Configuration;
using PowerStore.Services.Localization;
using PowerStore.Services.Security;
using PowerStore.Services.Stores;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PowerStore.Plugin.ExternalAuth.Facebook.Controllers
{
    public class FacebookAuthenticationController : BasePluginController
    {
        #region Fields

        private readonly FacebookExternalAuthSettings _facebookExternalAuthSettings;
        private readonly IExternalAuthenticationService _externalAuthenticationService;
        private readonly ILocalizationService _localizationService;
        private readonly IPermissionService _permissionService;
        private readonly ISettingService _settingService;

        #endregion

        #region Ctor

        public FacebookAuthenticationController(FacebookExternalAuthSettings facebookExternalAuthSettings,
            IExternalAuthenticationService externalAuthenticationService,
            ILocalizationService localizationService,
            IPermissionService permissionService,
            ISettingService settingService)
        {
            _facebookExternalAuthSettings = facebookExternalAuthSettings;
            _externalAuthenticationService = externalAuthenticationService;
            _localizationService = localizationService;
            _permissionService = permissionService;
            _settingService = settingService;
        }

        #endregion

        #region Methods

        [AuthorizeAdmin]
        [Area("Admin")]
        public async Task<IActionResult> Configure()
        {
            if (!await _permissionService.Authorize(StandardPermissionProvider.ManageExternalAuthenticationMethods))
                return AccessDeniedView();

            var model = new ConfigurationModel
            {
                ClientId = _facebookExternalAuthSettings.ClientKeyIdentifier,
                ClientSecret = _facebookExternalAuthSettings.ClientSecret,
            };
           

            return View("~/Plugins/ExternalAuth.Facebook/Views/Configure.cshtml", model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [AuthorizeAdmin]
        [Area("Admin")]
        public async Task<IActionResult> Configure(ConfigurationModel model)
        {
            if (!await _permissionService.Authorize(StandardPermissionProvider.ManageExternalAuthenticationMethods))
                return AccessDeniedView();

            if (!ModelState.IsValid)
                return await Configure();

            _facebookExternalAuthSettings.ClientKeyIdentifier = model.ClientId;
            _facebookExternalAuthSettings.ClientSecret = model.ClientSecret;
            await _settingService.SaveSetting(_facebookExternalAuthSettings);

            //now clear settings cache
            await _settingService.ClearCache();

            SuccessNotification(_localizationService.GetResource("Admin.Plugins.Saved"));

            return await Configure();
        }

        public IActionResult Login(string returnUrl)
        {
            if (!_externalAuthenticationService.ExternalAuthenticationMethodIsAvailable(FacebookAuthenticationDefaults.ProviderSystemName))
                throw new PowerStoreException("Facebook authentication module cannot be loaded");

            if (string.IsNullOrEmpty(_facebookExternalAuthSettings.ClientKeyIdentifier) || string.IsNullOrEmpty(_facebookExternalAuthSettings.ClientSecret))
                throw new PowerStoreException("Facebook authentication module not configured");

            //configure login callback action
            var authenticationProperties = new AuthenticationProperties
            {
                RedirectUri = Url.Action("LoginCallback", "FacebookAuthentication", new { returnUrl = returnUrl })
            };

            return Challenge(authenticationProperties, FacebookDefaults.AuthenticationScheme);
        }

        public async Task<IActionResult> LoginCallback(string returnUrl)
        {
            //authenticate Facebook user
            var authenticateResult = await HttpContext.AuthenticateAsync(FacebookDefaults.AuthenticationScheme);
            if (!authenticateResult.Succeeded || !authenticateResult.Principal.Claims.Any())
                return RedirectToRoute("Login");

            //create external authentication parameters
            var authenticationParameters = new ExternalAuthenticationParameters
            {
                ProviderSystemName = FacebookAuthenticationDefaults.ProviderSystemName,
                AccessToken = await HttpContext.GetTokenAsync(FacebookDefaults.AuthenticationScheme, "access_token"),
                Email = authenticateResult.Principal.FindFirst(claim => claim.Type == ClaimTypes.Email)?.Value,
                ExternalIdentifier = authenticateResult.Principal.FindFirst(claim => claim.Type == ClaimTypes.NameIdentifier)?.Value,
                ExternalDisplayIdentifier = authenticateResult.Principal.FindFirst(claim => claim.Type == ClaimTypes.Name)?.Value,
                Claims = authenticateResult.Principal.Claims.Select(claim => new ExternalAuthenticationClaim(claim.Type, claim.Value)).ToList()
            };

            //authenticate PowerStore user
            return await _externalAuthenticationService.Authenticate(authenticationParameters, returnUrl);
        }
        public IActionResult SignInFailed(string error_code, string error_message, string state)
        {
            //handle exception and display message to user
            var model = new FailedModel()
            {
                ErrorCode = error_code,
                ErrorMessage = error_message
            };
            return View("~/Plugins/ExternalAuth.Facebook/Views/SignInFailed.cshtml", model);
        }


        #endregion
    }
}