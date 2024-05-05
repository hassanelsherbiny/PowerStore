using DotLiquid;
using PowerStore.Domain.Blogs;
using PowerStore.Domain.Localization;
using PowerStore.Domain.Stores;
using PowerStore.Services.Seo;
using System.Collections.Generic;

namespace PowerStore.Services.Messages.DotLiquidDrops
{
    public partial class LiquidBlogComment : Drop
    {
        private BlogComment _blogComment;
        private BlogPost _blogPost;
        private Store _store;
        private readonly Language _language;
        public LiquidBlogComment(BlogComment blogComment, BlogPost blogPost, Store store, Language language)
        {
            _blogComment = blogComment;
            _blogPost = blogPost;
            _store = store;
            _language = language;
            AdditionalTokens = new Dictionary<string, string>();
        }

        public string BlogPostTitle
        {
            get { return _blogPost.Title; }
        }

        public string BlogPostURL
        {
            get
            {
                return $"{(_store.SslEnabled ? _store.SecureUrl : _store.Url)}{_blogPost.GetSeName(_language.Id)}";
            }
        }

        public IDictionary<string, string> AdditionalTokens { get; set; }
    }
}