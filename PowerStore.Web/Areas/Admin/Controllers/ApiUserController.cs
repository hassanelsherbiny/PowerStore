﻿using PowerStore.Core;
using PowerStore.Framework.Kendoui;
using PowerStore.Framework.Mvc;
using PowerStore.Framework.Security.Authorization;
using PowerStore.Services.Customers;
using PowerStore.Services.Security;
using PowerStore.Web.Areas.Admin.Extensions;
using PowerStore.Web.Areas.Admin.Models.Customers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PowerStore.Web.Areas.Admin.Controllers
{
    [PermissionAuthorize(PermissionSystemName.Maintenance)]
    public partial class ApiUserController : BaseAdminController
    {
        private readonly IUserApiService _userApiService;
        private readonly IEncryptionService _encryptionService;
        public ApiUserController(IUserApiService userApiService, IEncryptionService encryptionService)
        {
            _userApiService = userApiService;
            _encryptionService = encryptionService;
        }

        protected (string hashpassword, string privatekey) HashPassword(string password)
        {
            var pk = CommonHelper.GenerateRandomDigitCode(24);
            return (_encryptionService.EncryptText(password, pk), pk);
        }

        public IActionResult Index() => View();

        [HttpPost]
        public async Task<IActionResult> List(string email, DataSourceRequest command)
        {
            var model = (await _userApiService.GetUsers(email, command.Page - 1, command.PageSize))
                .Select(x => x.ToModel())
                .ToList();
            var gridModel = new DataSourceResult
            {
                Data = model,
                Total = model.Count
            };
            return Json(gridModel);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UserApiModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new DataSourceResult { Errors = ModelState.SerializeErrors() });
            }
            var userapi = await _userApiService.GetUserById(model.Id);
            if (userapi == null)
                throw new ArgumentException("No user api found with the specified id");
            if (ModelState.IsValid)
            {
                userapi = model.ToEntity(userapi);
                if(!string.IsNullOrEmpty(model.Password))
                {
                    var keys = HashPassword(model.Password);
                    userapi.Password = keys.hashpassword;
                    userapi.PrivateKey = keys.privatekey;
                    userapi.Token = Guid.NewGuid().ToString();
                }
                await _userApiService.UpdateUserApi(userapi);
                return new NullJsonResult();
            }
            return ErrorForKendoGridJson(ModelState);
        }

        [HttpPost]
        public async Task<IActionResult> Insert(UserApiModel model)
        {
            if (string.IsNullOrEmpty(model.Password))
                ModelState.AddModelError("", "Password is required");

            if (!ModelState.IsValid)
            {
                return Json(new DataSourceResult { Errors = ModelState.SerializeErrors() });
            }
            if (ModelState.IsValid)
            {
                var userapi = model.ToEntity();
                var keys = HashPassword(model.Password);
                userapi.Password = keys.hashpassword;
                userapi.PrivateKey = keys.privatekey;
                userapi.Token = Guid.NewGuid().ToString();
                await _userApiService.InsertUserApi(userapi);
                return new NullJsonResult();
            }
            return ErrorForKendoGridJson(ModelState);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            var userapi = await _userApiService.GetUserById(id);
            if (userapi == null)
                throw new ArgumentException("No user found with the specified id");
            if (ModelState.IsValid)
            {
                await _userApiService.DeleteUserApi(userapi);
                return new NullJsonResult();
            }
            return ErrorForKendoGridJson(ModelState);
        }

    }
}
