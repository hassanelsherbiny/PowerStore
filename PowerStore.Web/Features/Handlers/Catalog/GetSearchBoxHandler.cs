using PowerStore.Core.Caching;
using PowerStore.Domain.Catalog;
using PowerStore.Services.Catalog;
using PowerStore.Services.Customers;
using PowerStore.Services.Localization;
using PowerStore.Web.Features.Models.Catalog;
using PowerStore.Web.Infrastructure.Cache;
using PowerStore.Web.Models.Catalog;
using MediatR;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Features.Handlers.Catalog
{
    public class GetSearchBoxHandler : IRequestHandler<GetSearchBox, SearchBoxModel>
    {
        private readonly ICacheBase _cacheBase;
        private readonly ICategoryService _categoryService;
        private readonly ILocalizationService _localizationService;
        private readonly CatalogSettings _catalogSettings;

        public GetSearchBoxHandler(
            ICacheBase cacheManager,
            ICategoryService categoryService,
            ILocalizationService localizationService,
            CatalogSettings catalogSettings)
        {
            _cacheBase = cacheManager;
            _categoryService = categoryService;
            _localizationService = localizationService;
            _catalogSettings = catalogSettings;
        }

        public async Task<SearchBoxModel> Handle(GetSearchBox request, CancellationToken cancellationToken)
        {
            string cacheKey = string.Format(ModelCacheEventConst.CATEGORY_ALL_SEARCHBOX,
                string.Join(",", request.Customer.GetCustomerRoleIds()),
                request.Store.Id);

            return await _cacheBase.GetAsync(cacheKey, async () =>
            {
                var searchbocategories = await _categoryService.GetAllCategoriesSearchBox();

                var availableCategories = new List<SelectListItem>();
                if (searchbocategories.Any())
                {
                    availableCategories.Add(new SelectListItem { Text = _localizationService.GetResource("Common.All"), Value = "" });
                    foreach (var s in searchbocategories)
                        availableCategories.Add(new SelectListItem { Text = s.Name, Value = s.Id.ToString() });
                }

                var model = new SearchBoxModel {
                    AutoCompleteEnabled = _catalogSettings.ProductSearchAutoCompleteEnabled,
                    ShowProductImagesInSearchAutoComplete = _catalogSettings.ShowProductImagesInSearchAutoComplete,
                    SearchTermMinimumLength = _catalogSettings.ProductSearchTermMinimumLength,
                    AvailableCategories = availableCategories
                };

                return model;
            });

        }
    }
}
