using PowerStore.Core.Mapper;
using PowerStore.Domain.Catalog;
using PowerStore.Web.Areas.Admin.Models.Templates;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class ProductTemplateMappingExtensions
    {
        public static ProductTemplateModel ToModel(this ProductTemplate entity)
        {
            return entity.MapTo<ProductTemplate, ProductTemplateModel>();
        }

        public static ProductTemplate ToEntity(this ProductTemplateModel model)
        {
            return model.MapTo<ProductTemplateModel, ProductTemplate>();
        }

        public static ProductTemplate ToEntity(this ProductTemplateModel model, ProductTemplate destination)
        {
            return model.MapTo(destination);
        }
    }
}