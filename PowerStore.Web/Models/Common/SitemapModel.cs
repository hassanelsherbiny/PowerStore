using PowerStore.Core.Models;
using PowerStore.Web.Models.Catalog;
using PowerStore.Web.Models.Topics;
using PowerStore.Web.Models.Blogs;
using PowerStore.Web.Models.Knowledgebase;
using System.Collections.Generic;

namespace PowerStore.Web.Models.Common
{
    public partial class SitemapModel : BaseModel
    {
        public SitemapModel()
        {
            Products = new List<ProductOverviewModel>();
            Categories = new List<CategoryModel>();
            Manufacturers = new List<ManufacturerModel>();
            Topics = new List<TopicModel>();
            BlogPosts = new List<BlogPostModel>();
            KnowledgebaseArticles = new List<KnowledgebaseItemModel>();
        }
        public IList<ProductOverviewModel> Products { get; set; }
        public IList<CategoryModel> Categories { get; set; }
        public IList<ManufacturerModel> Manufacturers { get; set; }
        public IList<TopicModel> Topics { get; set; }
        public IList<BlogPostModel> BlogPosts { get; set; }
        public IList<KnowledgebaseItemModel> KnowledgebaseArticles { get; set; }

        public bool NewsEnabled { get; set; }
        public bool BlogEnabled { get; set; }
        public bool KnowledgebaseEnabled { get; set; }
    }
}