using PowerStore.Core.Caching;
using PowerStore.Domain.Media;
using PowerStore.Services.Catalog;
using PowerStore.Services.Customers;
using PowerStore.Services.Localization;
using PowerStore.Services.Media;
using PowerStore.Web.Extensions;
using PowerStore.Web.Features.Models.Catalog;
using PowerStore.Web.Infrastructure.Cache;
using PowerStore.Web.Models.Catalog;
using PowerStore.Web.Models.Media;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Features.Handlers.Catalog
{
    public class GetManufacturerAllHandler : IRequestHandler<GetManufacturerAll, IList<ManufacturerModel>>
    {
        private readonly IManufacturerService _manufacturerService;
        private readonly IPictureService _pictureService;
        private readonly ILocalizationService _localizationService;
        private readonly ICacheBase _cacheBase;
        private readonly MediaSettings _mediaSettings;

        public GetManufacturerAllHandler(IManufacturerService manufacturerService,
            IPictureService pictureService,
            ILocalizationService localizationService,
            ICacheBase cacheManager,
            MediaSettings mediaSettings)
        {
            _manufacturerService = manufacturerService;
            _pictureService = pictureService;
            _localizationService = localizationService;
            _cacheBase = cacheManager;
            _mediaSettings = mediaSettings;
        }

        public async Task<IList<ManufacturerModel>> Handle(GetManufacturerAll request, CancellationToken cancellationToken)
        {
            string cacheKey = string.Format(ModelCacheEventConst.MANUFACTURER_ALL_MODEL_KEY,
                request.Language.Id,
                string.Join(",", request.Customer.GetCustomerRoleIds()),
                request.Store.Id);
            return await _cacheBase.GetAsync(cacheKey, () => PrepareManufacturerAll(request));            
        }

        private async Task<List<ManufacturerModel>> PrepareManufacturerAll(GetManufacturerAll request)
        {
            var model = new List<ManufacturerModel>();
            var manufacturers = await _manufacturerService.GetAllManufacturers(storeId: request.Store.Id);
            foreach (var manufacturer in manufacturers)
            {
                var modelMan = manufacturer.ToModel(request.Language);

                //prepare picture model
                modelMan.PictureModel = new PictureModel {
                    Id = manufacturer.PictureId,
                    FullSizeImageUrl = await _pictureService.GetPictureUrl(manufacturer.PictureId),
                    ImageUrl = await _pictureService.GetPictureUrl(manufacturer.PictureId, _mediaSettings.ManufacturerThumbPictureSize),
                    Title = string.Format(_localizationService.GetResource("Media.Manufacturer.ImageLinkTitleFormat"), modelMan.Name),
                    AlternateText = string.Format(_localizationService.GetResource("Media.Manufacturer.ImageAlternateTextFormat"), modelMan.Name)
                };
                model.Add(modelMan);
            }
            return model;
        }
    }
}
