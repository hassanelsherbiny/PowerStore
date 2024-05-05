using PowerStore.Core;
using PowerStore.Core.Caching;
using PowerStore.Domain.Blogs;
using PowerStore.Services.Blogs;
using PowerStore.Web.Features.Models.Blogs;
using PowerStore.Web.Infrastructure.Cache;
using PowerStore.Web.Models.Blogs;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PowerStore.Web.Features.Handlers.Blogs
{
    public class GetBlogPostTagListHandler : IRequestHandler<GetBlogPostTagList, BlogPostTagListModel>
    {
        private readonly IBlogService _blogService;
        private readonly ICacheBase _cacheBase;
        private readonly IWorkContext _workContext;
        private readonly IStoreContext _storeContext;

        private readonly BlogSettings _blogSettings;

        public GetBlogPostTagListHandler(IBlogService blogService, ICacheBase cacheManager, IWorkContext workContext, IStoreContext storeContext, BlogSettings blogSettings)
        {
            _blogService = blogService;
            _cacheBase = cacheManager;
            _workContext = workContext;
            _storeContext = storeContext;
            _blogSettings = blogSettings;
        }

        public async Task<BlogPostTagListModel> Handle(GetBlogPostTagList request, CancellationToken cancellationToken)
        {
            var cacheKey = string.Format(ModelCacheEventConst.BLOG_TAGS_MODEL_KEY, _workContext.WorkingLanguage.Id, _storeContext.CurrentStore.Id);
            var cachedModel = await _cacheBase.GetAsync(cacheKey, async () =>
            {
                var model = new BlogPostTagListModel();

                //get tags
                var tags = await _blogService.GetAllBlogPostTags(_storeContext.CurrentStore.Id);
                tags = tags.OrderByDescending(x => x.BlogPostCount)
                    .Take(_blogSettings.NumberOfTags)
                    .ToList();
                //sorting
                tags = tags.OrderBy(x => x.Name).ToList();

                foreach (var tag in tags)
                    model.Tags.Add(new BlogPostTagModel {
                        Name = tag.Name,
                        BlogPostCount = tag.BlogPostCount
                    });
                return model;
            });
            return cachedModel;
        }
    }
}
