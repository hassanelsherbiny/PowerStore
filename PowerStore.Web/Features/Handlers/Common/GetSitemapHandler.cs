using PowerStore.Core.Caching;
using PowerStore.Domain.Blogs;
using PowerStore.Domain.Common;
using PowerStore.Domain.Knowledgebase;
using PowerStore.Domain.News;
using PowerStore.Services.Blogs;
using PowerStore.Services.Catalog;
using PowerStore.Services.Customers;
using PowerStore.Services.Knowledgebase;
using PowerStore.Services.Localization;
using PowerStore.Services.Seo;
using PowerStore.Services.Topics;
using PowerStore.Web.Extensions;
using PowerStore.Web.Features.Models.Common;
using PowerStore.Web.Infrastructure.Cache;
using PowerStore.Web.Models.Blogs;
using PowerStore.Web.Models.Catalog;
using PowerStore.Web.Models.Common;
using PowerStore.Web.Models.Knowledgebase;
using PowerStore.Web.Models.Topics;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Features.Handlers.Common
{
    public class GetSitemapHandler : IRequestHandler<GetSitemap, SitemapModel>
    {
        private readonly ICacheBase _cacheBase;
        private readonly ICategoryService _categoryService;
        private readonly IManufacturerService _manufacturerService;
        private readonly IProductService _productService;
        private readonly ITopicService _topicService;
        private readonly IBlogService _blogService;
        private readonly IKnowledgebaseService _knowledgebaseService;

        private readonly CommonSettings _commonSettings;
        private readonly BlogSettings _blogSettings;
        private readonly NewsSettings _newsSettings;
        private readonly KnowledgebaseSettings _knowledgebaseSettings;

        public GetSitemapHandler(ICacheBase cacheManager,
            ICategoryService categoryService,
            IManufacturerService manufacturerService,
            IProductService productService,
            ITopicService topicService,
            IBlogService blogService,
            IKnowledgebaseService knowledgebaseService,
            CommonSettings commonSettings,
            BlogSettings blogSettings,
            NewsSettings newsSettings,
            KnowledgebaseSettings knowledgebaseSettings)
        {
            _cacheBase = cacheManager;
            _categoryService = categoryService;
            _manufacturerService = manufacturerService;
            _productService = productService;
            _topicService = topicService;
            _blogService = blogService;
            _knowledgebaseService = knowledgebaseService;

            _commonSettings = commonSettings;
            _blogSettings = blogSettings;
            _newsSettings = newsSettings;
            _knowledgebaseSettings = knowledgebaseSettings;
        }

        public async Task<SitemapModel> Handle(GetSitemap request, CancellationToken cancellationToken)
        {
            string cacheKey = string.Format(ModelCacheEventConst.SITEMAP_PAGE_MODEL_KEY,
                request.Language.Id,
                string.Join(",", request.Customer.GetCustomerRoleIds()),
                request.Store.Id);
            var cachedModel = await _cacheBase.GetAsync(cacheKey, async () =>
            {
                var model = new SitemapModel {
                    BlogEnabled = _blogSettings.Enabled,
                    NewsEnabled = _newsSettings.Enabled,
                    KnowledgebaseEnabled = _knowledgebaseSettings.Enabled
                };
                //categories
                if (_commonSettings.SitemapIncludeCategories)
                {
                    var categories = await _categoryService.GetAllCategories();
                    model.Categories = categories.Select(x => x.ToModel(request.Language)).ToList();
                }
                //manufacturers
                if (_commonSettings.SitemapIncludeManufacturers)
                {
                    var manufacturers = await _manufacturerService.GetAllManufacturers();
                    model.Manufacturers = manufacturers.Select(x => x.ToModel(request.Language)).ToList();
                }
                //products
                if (_commonSettings.SitemapIncludeProducts)
                {
                    //limit product to 200 until paging is supported on this page
                    var products = (await _productService.SearchProducts(
                        storeId: request.Store.Id,
                        visibleIndividuallyOnly: true,
                        pageSize: 200)).products;
                    model.Products = products.Select(product => new ProductOverviewModel {
                        Id = product.Id,
                        Name = product.GetLocalized(x => x.Name, request.Language.Id),
                        ShortDescription = product.GetLocalized(x => x.ShortDescription, request.Language.Id),
                        FullDescription = product.GetLocalized(x => x.FullDescription, request.Language.Id),
                        SeName = product.GetSeName(request.Language.Id),
                    }).ToList();
                }

                //topics
                var now = DateTime.UtcNow;
                var topics = (await _topicService.GetAllTopics(request.Store.Id))
                    .Where(t => t.IncludeInSitemap && (!t.StartDateUtc.HasValue || t.StartDateUtc < now) && (!t.EndDateUtc.HasValue || t.EndDateUtc > now))
                    .ToList();
                model.Topics = topics.Select(topic => new TopicModel {
                    Id = topic.Id,
                    SystemName = topic.GetLocalized(x => x.SystemName, request.Language.Id),
                    IncludeInSitemap = topic.IncludeInSitemap,
                    IsPasswordProtected = topic.IsPasswordProtected,
                    Title = topic.GetLocalized(x => x.Title, request.Language.Id),
                }).ToList();

                //blog posts
                var blogposts = (await _blogService.GetAllBlogPosts(request.Store.Id))
                    .ToList();
                model.BlogPosts = blogposts.Select(blogpost => new BlogPostModel {
                    Id = blogpost.Id,
                    SeName = blogpost.GetSeName(request.Language.Id),
                    Title = blogpost.GetLocalized(x => x.Title, request.Language.Id),
                }).ToList();

                //knowledgebase
                var knowledgebasearticles = (await _knowledgebaseService.GetPublicKnowledgebaseArticles()).ToList();
                model.KnowledgebaseArticles = knowledgebasearticles.Select(knowledgebasearticle => new KnowledgebaseItemModel {
                    Id = knowledgebasearticle.Id,
                    SeName = knowledgebasearticle.GetSeName(request.Language.Id),
                    Name = knowledgebasearticle.GetLocalized(x => x.Name, request.Language.Id)
                }).ToList();

                return model;
            });
            return cachedModel;
        }
    }
}
