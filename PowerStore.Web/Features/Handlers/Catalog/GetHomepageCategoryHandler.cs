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
    public class GetHomepageCategoryHandler : IRequestHandler<GetHomepageCategory, IList<CategoryModel>>
    {
        private readonly ICategoryService _categoryService;
        private readonly ICacheBase _cacheBase;
        private readonly IPictureService _pictureService;
        private readonly ILocalizationService _localizationService;
        private readonly MediaSettings _mediaSettings;

        public GetHomepageCategoryHandler(
            ICategoryService categoryService,
            ICacheBase cacheManager,
            IPictureService pictureService,
            ILocalizationService localizationService,
            MediaSettings mediaSettings)
        {
            _categoryService = categoryService;
            _cacheBase = cacheManager;
            _pictureService = pictureService;
            _localizationService = localizationService;
            _mediaSettings = mediaSettings;
        }

        public async Task<IList<CategoryModel>> Handle(GetHomepageCategory request, CancellationToken cancellationToken)
        {
            string categoriesCacheKey = string.Format(ModelCacheEventConst.CATEGORY_HOMEPAGE_KEY,
                            string.Join(",", request.Customer.GetCustomerRoleIds()),
                            request.Store.Id,
                            request.Language.Id);

            var model = await _cacheBase.GetAsync(categoriesCacheKey, async () =>
            {
                var cat = new List<CategoryModel>();
                foreach (var x in (await _categoryService.GetAllCategoriesDisplayedOnHomePage()))
                {
                    var catModel = x.ToModel(request.Language);
                    //prepare picture model
                    catModel.PictureModel = new PictureModel {
                        Id = x.PictureId,
                        FullSizeImageUrl = await _pictureService.GetPictureUrl(x.PictureId),
                        ImageUrl = await _pictureService.GetPictureUrl(x.PictureId, _mediaSettings.CategoryThumbPictureSize),
                        Title = string.Format(_localizationService.GetResource("Media.Category.ImageLinkTitleFormat"), catModel.Name),
                        AlternateText = string.Format(_localizationService.GetResource("Media.Category.ImageAlternateTextFormat"), catModel.Name)
                    };
                    cat.Add(catModel);
                }
                return cat;
            });

            return model;
        }
    }
}
