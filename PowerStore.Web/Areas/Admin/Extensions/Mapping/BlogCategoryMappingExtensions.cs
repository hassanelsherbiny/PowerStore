using PowerStore.Core.Mapper;
using PowerStore.Domain.Blogs;
using PowerStore.Web.Areas.Admin.Models.Blogs;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class BlogCategoryMappingExtensions
    {
        public static BlogCategoryModel ToModel(this BlogCategory entity)
        {
            return entity.MapTo<BlogCategory, BlogCategoryModel>();
        }

        public static BlogCategory ToEntity(this BlogCategoryModel model)
        {
            return model.MapTo<BlogCategoryModel, BlogCategory>();
        }

        public static BlogCategory ToEntity(this BlogCategoryModel model, BlogCategory destination)
        {
            return model.MapTo(destination);
        }
    }
}