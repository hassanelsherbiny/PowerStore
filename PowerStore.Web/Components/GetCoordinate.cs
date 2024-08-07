﻿using PowerStore.Core;
using PowerStore.Domain.Customers;
using PowerStore.Framework.Components;
using PowerStore.Web.Models.Common;
using Microsoft.AspNetCore.Mvc;

namespace PowerStore.Web.ViewComponents
{
    public class GetCoordinateViewComponent : BaseViewComponent
    {
        private readonly CustomerSettings _customerSettings;
        private readonly IWorkContext _workContext;

        public GetCoordinateViewComponent(CustomerSettings customerSettings, IWorkContext workContext)
        {
            _customerSettings = customerSettings;
            _workContext = workContext;
        }

        public IViewComponentResult Invoke()
        {
            if (!_customerSettings.GeoEnabled)
                return Content("");

            if(_workContext.CurrentCustomer.Coordinates == null)
                return View(new LocationModel());

            var model = new LocationModel {
                Longitude = _workContext.CurrentCustomer.Coordinates.X,
                Latitude = _workContext.CurrentCustomer.Coordinates.Y
            };
            return View(model);
        }
    }
}