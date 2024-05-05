using PowerStore.Core.Mapper;
using PowerStore.Domain.Catalog;
using PowerStore.Web.Areas.Admin.Models.Catalog;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class CategoryMappingExtensions
    {
        public static CategoryModel ToModel(this Category entity)
        {
            return entity.MapTo<Category, CategoryModel>();
        }

        public static Category ToEntity(this CategoryModel model)
        {
            return model.MapTo<CategoryModel, Category>();
        }

        public static Category ToEntity(this CategoryModel model, Category destination)
        {
            return model.MapTo(destination);
        }

    }
}