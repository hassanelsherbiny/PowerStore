using PowerStore.Core;
using PowerStore.Core.Caching;
using PowerStore.Domain;
using PowerStore.Domain.Catalog;
using PowerStore.Domain.Media;
using PowerStore.Services.Catalog;
using PowerStore.Services.Customers;
using PowerStore.Services.Localization;
using PowerStore.Services.Media;
using PowerStore.Services.Queries.Models.Catalog;
using PowerStore.Web.Extensions;
using PowerStore.Web.Features.Models.Catalog;
using PowerStore.Web.Features.Models.Products;
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
    public class GetManufacturerFeaturedProductsHandler : IRequestHandler<GetManufacturerFeaturedProducts, IList<ManufacturerModel>>
    {
        private readonly IMediator _mediator;
        private readonly IManufacturerService _manufacturerService;
        private readonly ICacheBase _cacheBase;
        private readonly IPictureService _pictureService;
        private readonly ILocalizationService _localizationService;
        private readonly MediaSettings _mediaSettings;
        private readonly CatalogSettings _catalogSettings;

        public GetManufacturerFeaturedProductsHandler(
            IMediator mediator,
            IManufacturerService manufacturerService,
            ICacheBase cacheManager,
            IPictureService pictureService,
            ILocalizationService localizationService,
            MediaSettings mediaSettings,
            CatalogSettings catalogSettings)
        {
            _mediator = mediator;
            _manufacturerService = manufacturerService;
            _cacheBase = cacheManager;
            _pictureService = pictureService;
            _localizationService = localizationService;
            _mediaSettings = mediaSettings;
            _catalogSettings = catalogSettings;
        }

        public async Task<IList<ManufacturerModel>> Handle(GetManufacturerFeaturedProducts request, CancellationToken cancellationToken)
        {
            string manufCacheKey = string.Format(ModelCacheEventConst.MANUFACTURER_FEATURED_PRODUCT_HOMEPAGE_KEY,
                            string.Join(",", request.Customer.GetCustomerRoleIds()), request.Store.Id,
                            request.Language.Id);

            var model = await _cacheBase.GetAsync(manufCacheKey, async () =>
            {
                var manufList = new List<ManufacturerModel>();
                var manufmodel = await _manufacturerService.GetAllManufacturerFeaturedProductsOnHomePage();
                foreach (var x in manufmodel)
                {
                    var manModel = x.ToModel(request.Language);
                    //prepare picture model
                    manModel.PictureModel = new PictureModel {
                        Id = x.PictureId,
                        FullSizeImageUrl = await _pictureService.GetPictureUrl(x.PictureId),
                        ImageUrl = await _pictureService.GetPictureUrl(x.PictureId, _mediaSettings.CategoryThumbPictureSize),
                        Title = string.Format(_localizationService.GetResource("Media.Category.ImageLinkTitleFormat"), manModel.Name),
                        AlternateText = string.Format(_localizationService.GetResource("Media.Category.ImageAlternateTextFormat"), manModel.Name)
                    };
                    manufList.Add(manModel);
                }
                return manufList;
            });

            foreach (var item in model)
            {
                //We cache a value indicating whether we have featured products
                IPagedList<Product> featuredProducts = null;

                string cacheKey = string.Format(ModelCacheEventConst.MANUFACTURER_HAS_FEATURED_PRODUCTS_KEY,
                    item.Id,
                    string.Join(",", request.Customer.GetCustomerRoleIds()),
                    request.Store.Id);

                var hasFeaturedProductsCache = await _cacheBase.GetAsync<bool?>(cacheKey, async () =>
                {
                    featuredProducts = (await _mediator.Send(new GetSearchProductsQuery() {
                        PageSize = _catalogSettings.LimitOfFeaturedProducts,
                        ManufacturerId = item.Id,
                        Customer = request.Customer,
                        StoreId = request.Store.Id,
                        VisibleIndividuallyOnly = true,
                        FeaturedProducts = true
                    })).products;
                    return featuredProducts.Any();
                });

                if (hasFeaturedProductsCache.Value && featuredProducts == null)
                {
                    //cache indicates that the manufacturer has featured products
                    //let's load them
                    featuredProducts = (await _mediator.Send(new GetSearchProductsQuery() {
                        PageSize = _catalogSettings.LimitOfFeaturedProducts,
                        Customer = request.Customer,
                        ManufacturerId = item.Id,
                        StoreId = request.Store.Id,
                        VisibleIndividuallyOnly = true,
                        FeaturedProducts = true
                    })).products;
                }
                if (featuredProducts != null && featuredProducts.Any())
                {
                    item.FeaturedProducts = (await _mediator.Send(new GetProductOverview() {
                        Products = featuredProducts,
                    })).ToList();
                }
            }
            return model;
        }
    }
}
