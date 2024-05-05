using PowerStore.Core.Mapper;
using PowerStore.Domain.Directory;
using PowerStore.Web.Areas.Admin.Models.Directory;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class MeasureUnitMappingExtensions
    {
        public static MeasureUnitModel ToModel(this MeasureUnit entity)
        {
            return entity.MapTo<MeasureUnit, MeasureUnitModel>();
        }

        public static MeasureUnit ToEntity(this MeasureUnitModel model)
        {
            return model.MapTo<MeasureUnitModel, MeasureUnit>();
        }

        public static MeasureUnit ToEntity(this MeasureUnitModel model, MeasureUnit destination)
        {
            return model.MapTo(destination);
        }
    }
}