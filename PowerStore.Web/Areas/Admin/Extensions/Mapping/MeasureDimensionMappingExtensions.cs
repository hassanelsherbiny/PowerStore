using PowerStore.Core.Mapper;
using PowerStore.Domain.Directory;
using PowerStore.Web.Areas.Admin.Models.Directory;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class MeasureDimensionMappingExtensions
    {
        public static MeasureDimensionModel ToModel(this MeasureDimension entity)
        {
            return entity.MapTo<MeasureDimension, MeasureDimensionModel>();
        }

        public static MeasureDimension ToEntity(this MeasureDimensionModel model)
        {
            return model.MapTo<MeasureDimensionModel, MeasureDimension>();
        }

        public static MeasureDimension ToEntity(this MeasureDimensionModel model, MeasureDimension destination)
        {
            return model.MapTo(destination);
        }
    }
}