using PowerStore.Core;
using PowerStore.Core.Caching;
using PowerStore.Domain.Catalog;
using PowerStore.Framework.Components;
using PowerStore.Services.Catalog;
using PowerStore.Web.Features.Models.Products;
using PowerStore.Web.Infrastructure.Cache;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace PowerStore.Web.Components
{
    public class SimilarProductsViewComponent : BaseViewComponent
    {
        #region Fields
        private readonly ICacheBase _cacheBase;
        private readonly IProductService _productService;
        private readonly IStoreContext _storeContext;
        private readonly IMediator _mediator;

        private readonly CatalogSettings _catalogSettings;

        #endregion

        #region Constructors
        public SimilarProductsViewComponent(
            ICacheBase cacheManager,
            IProductService productService,
            IStoreContext storeContext,
            IMediator mediator,
            CatalogSettings catalogSettings)
        {
            _cacheBase = cacheManager;
            _productService = productService;
            _storeContext = storeContext;
            _mediator = mediator;
            _catalogSettings = catalogSettings;
        }
        #endregion

        #region Invoker

        public async Task<IViewComponentResult> InvokeAsync(string productId, int? productThumbPictureSize)
        {

            var productIds = await _cacheBase.GetAsync(string.Format(ModelCacheEventConst.PRODUCTS_SIMILAR_IDS_KEY, productId, _storeContext.CurrentStore.Id),
                   async () => (await _productService.GetProductById(productId)).SimilarProducts.OrderBy(x => x.DisplayOrder).Select(x => x.ProductId2).ToArray());

            var products = await _productService.GetProductsByIds(productIds);

            if (!products.Any())
                return Content("");

            var model = await _mediator.Send(new GetProductOverview() {
                PreparePictureModel = true,
                PreparePriceModel = true,
                PrepareSpecificationAttributes = _catalogSettings.ShowSpecAttributeOnCatalogPages,
                ProductThumbPictureSize = productThumbPictureSize,
                Products = products
            });

            return View(model);
        }

        #endregion
    }
}
