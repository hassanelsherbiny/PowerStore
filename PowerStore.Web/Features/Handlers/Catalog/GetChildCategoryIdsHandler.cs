using PowerStore.Core.Caching;
using PowerStore.Services.Catalog;
using PowerStore.Services.Customers;
using PowerStore.Web.Features.Models.Catalog;
using PowerStore.Web.Infrastructure.Cache;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Features.Handlers.Catalog
{
    public class GetChildCategoryIdsHandler : IRequestHandler<GetChildCategoryIds, IList<string>>
    {
        private readonly ICacheBase _cacheBase;
        private readonly ICategoryService _categoryService;

        public GetChildCategoryIdsHandler(ICacheBase cacheManager, ICategoryService categoryService)
        {
            _cacheBase = cacheManager;
            _categoryService = categoryService;
        }

        public async Task<IList<string>> Handle(GetChildCategoryIds request, CancellationToken cancellationToken)
        {
            return await GetChildCategoryIds(request);
        }

        private async Task<List<string>> GetChildCategoryIds(GetChildCategoryIds request)
        {
            string cacheKey = string.Format(ModelCacheEventConst.CATEGORY_CHILD_IDENTIFIERS_MODEL_KEY,
                request.ParentCategoryId,
                string.Join(",", request.Customer.GetCustomerRoleIds()),
                request.Store.Id);
            return await _cacheBase.GetAsync(cacheKey, async () =>
            {
                var categoriesIds = new List<string>();
                var categories = await _categoryService.GetAllCategoriesByParentCategoryId(request.ParentCategoryId);
                foreach (var category in categories)
                {
                    categoriesIds.Add(category.Id);
                    request.ParentCategoryId = category.Id;
                    categoriesIds.AddRange(await GetChildCategoryIds(request));
                }
                return categoriesIds;
            });
        }
    }
}
