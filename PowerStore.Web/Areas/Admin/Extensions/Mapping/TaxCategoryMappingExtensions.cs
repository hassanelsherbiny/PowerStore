using PowerStore.Core.Mapper;
using PowerStore.Domain.Tax;
using PowerStore.Web.Areas.Admin.Models.Tax;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class TaxCategoryMappingExtensions
    {
        public static TaxCategoryModel ToModel(this TaxCategory entity)
        {
            return entity.MapTo<TaxCategory, TaxCategoryModel>();
        }

        public static TaxCategory ToEntity(this TaxCategoryModel model)
        {
            return model.MapTo<TaxCategoryModel, TaxCategory>();
        }

        public static TaxCategory ToEntity(this TaxCategoryModel model, TaxCategory destination)
        {
            return model.MapTo(destination);
        }
    }
}