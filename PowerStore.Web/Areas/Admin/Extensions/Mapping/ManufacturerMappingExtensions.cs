using PowerStore.Core.Mapper;
using PowerStore.Domain.Catalog;
using PowerStore.Web.Areas.Admin.Models.Catalog;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class ManufacturerMappingExtensions
    {
        public static ManufacturerModel ToModel(this Manufacturer entity)
        {
            return entity.MapTo<Manufacturer, ManufacturerModel>();
        }

        public static Manufacturer ToEntity(this ManufacturerModel model)
        {
            return model.MapTo<ManufacturerModel, Manufacturer>();
        }

        public static Manufacturer ToEntity(this ManufacturerModel model, Manufacturer destination)
        {
            return model.MapTo(destination);
        }
    }
}