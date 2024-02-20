﻿using Grand.Core.Caching;
using Grand.Services.Customers;
using Grand.Services.Seo;
using Grand.Web.Features.Models.Common;
using Grand.Web.Infrastructure.Cache;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Grand.Web.Features.Handlers.Common
{
    public class GetSitemapXMLHandler : IRequestHandler<GetSitemapXml, string>
    {
        private readonly ISitemapGenerator _sitemapGenerator;
        private readonly ICacheBase _cacheBase;

        public GetSitemapXMLHandler(ISitemapGenerator sitemapGenerator, ICacheBase cacheManager)
        {
            _sitemapGenerator = sitemapGenerator;
            _cacheBase = cacheManager;
        }

        public async Task<string> Handle(GetSitemapXml request, CancellationToken cancellationToken)
        {
            string cacheKey = string.Format(ModelCacheEventConst.SITEMAP_SEO_MODEL_KEY, request.Id,
                request.Language.Id,
                string.Join(",", request.Customer.GetCustomerRoleIds()),
                request.Store.Id);
            var siteMap = await _cacheBase.GetAsync(cacheKey, () => _sitemapGenerator.Generate(request.UrlHelper, request.Id, request.Language.Id, request.Store.Id));
            return siteMap;
        }
    }
}
