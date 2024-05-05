using PowerStore.Core.Mapper;
using PowerStore.Domain.Catalog;
using PowerStore.Web.Areas.Admin.Models.Templates;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class ManufacturerTemplateMappingExtensions
    {
        public static ManufacturerTemplateModel ToModel(this ManufacturerTemplate entity)
        {
            return entity.MapTo<ManufacturerTemplate, ManufacturerTemplateModel>();
        }

        public static ManufacturerTemplate ToEntity(this ManufacturerTemplateModel model)
        {
            return model.MapTo<ManufacturerTemplateModel, ManufacturerTemplate>();
        }

        public static ManufacturerTemplate ToEntity(this ManufacturerTemplateModel model, ManufacturerTemplate destination)
        {
            return model.MapTo(destination);
        }
    }
}