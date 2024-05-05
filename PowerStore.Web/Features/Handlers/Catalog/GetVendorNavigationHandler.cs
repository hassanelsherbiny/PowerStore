using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using PowerStore.Core.Caching;
using PowerStore.Domain.Vendors;
using PowerStore.Services.Localization;
using PowerStore.Services.Seo;
using PowerStore.Services.Vendors;
using PowerStore.Web.Features.Models.Catalog;
using PowerStore.Web.Infrastructure.Cache;
using PowerStore.Web.Models.Catalog;
using MediatR;

namespace PowerStore.Web.Features.Handlers.Catalog
{
    public class GetVendorNavigationHandler : IRequestHandler<GetVendorNavigation, VendorNavigationModel>
    {
        private readonly ICacheBase _cacheBase;
        private readonly IVendorService _vendorService;
        private readonly VendorSettings _vendorSettings;

        public GetVendorNavigationHandler(ICacheBase cacheManager, IVendorService vendorService, VendorSettings vendorSettings)
        {
            _cacheBase = cacheManager;
            _vendorService = vendorService;
            _vendorSettings = vendorSettings;
        }

        public async Task<VendorNavigationModel> Handle(GetVendorNavigation request, CancellationToken cancellationToken)
        {
            string cacheKey = ModelCacheEventConst.VENDOR_NAVIGATION_MODEL_KEY;
            var cacheModel = await _cacheBase.GetAsync(cacheKey, async () =>
            {
                var vendors = await _vendorService.GetAllVendors(pageSize: _vendorSettings.VendorsBlockItemsToDisplay);
                var model = new VendorNavigationModel {
                    TotalVendors = vendors.TotalCount
                };

                foreach (var vendor in vendors)
                {
                    model.Vendors.Add(new VendorBriefInfoModel {
                        Id = vendor.Id,
                        Name = vendor.GetLocalized(x => x.Name, request.Language.Id),
                        SeName = vendor.GetSeName(request.Language.Id),
                    });
                }
                return model;
            });
            return cacheModel;
        }
    }
}
