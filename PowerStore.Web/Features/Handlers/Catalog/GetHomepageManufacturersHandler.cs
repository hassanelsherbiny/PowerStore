using PowerStore.Core.Caching;
using PowerStore.Domain.Media;
using PowerStore.Services.Catalog;
using PowerStore.Services.Localization;
using PowerStore.Services.Media;
using PowerStore.Web.Extensions;
using PowerStore.Web.Features.Models.Catalog;
using PowerStore.Web.Infrastructure.Cache;
using PowerStore.Web.Models.Catalog;
using PowerStore.Web.Models.Media;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Features.Handlers.Catalog
{
    public class GetHomepageManufacturersHandler : IRequestHandler<GetHomepageManufacturers, IList<ManufacturerModel>>
    {
        private readonly ICacheBase _cacheBase;
        private readonly IManufacturerService _manufacturerService;
        private readonly IPictureService _pictureService;
        private readonly ILocalizationService _localizationService;
        private readonly MediaSettings _mediaSettings;

        public GetHomepageManufacturersHandler(
            ICacheBase cacheManager, 
            IManufacturerService manufacturerService, 
            IPictureService pictureService, 
            ILocalizationService localizationService, 
            MediaSettings mediaSettings)
        {
            _cacheBase = cacheManager;
            _manufacturerService = manufacturerService;
            _pictureService = pictureService;
            _localizationService = localizationService;
            _mediaSettings = mediaSettings;
        }

        public async Task<IList<ManufacturerModel>> Handle(GetHomepageManufacturers request, CancellationToken cancellationToken)
        {
            string manufacturersCacheKey = string.Format(ModelCacheEventConst.MANUFACTURER_HOMEPAGE_KEY, request.Store.Id, request.Language.Id);

            var model = await _cacheBase.GetAsync(manufacturersCacheKey, async () =>
            {
                var modelManuf = new List<ManufacturerModel>();
                var manuf = await _manufacturerService.GetAllManufacturers(storeId: request.Store.Id);
                foreach (var x in manuf.Where(x => x.ShowOnHomePage))
                {
                    var manModel = x.ToModel(request.Language);
                    //prepare picture model
                    manModel.PictureModel = new PictureModel {
                        Id = x.PictureId,
                        FullSizeImageUrl = await _pictureService.GetPictureUrl(x.PictureId),
                        ImageUrl = await _pictureService.GetPictureUrl(x.PictureId, _mediaSettings.CategoryThumbPictureSize),
                        Title = string.Format(_localizationService.GetResource("Media.Manufacturer.ImageLinkTitleFormat"), manModel.Name),
                        AlternateText = string.Format(_localizationService.GetResource("Media.Manufacturer.ImageAlternateTextFormat"), manModel.Name)
                    };
                    modelManuf.Add(manModel);
                }
                return modelManuf;
            });
            return model;

        }
    }
}
