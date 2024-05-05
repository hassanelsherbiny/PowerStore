using PowerStore.Core.Mapper;
using PowerStore.Services.Cms;
using PowerStore.Web.Areas.Admin.Models.Cms;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class IWidgetPluginMappingExtensions
    {
        public static WidgetModel ToModel(this IWidgetPlugin entity)
        {
            return entity.MapTo<IWidgetPlugin, WidgetModel>();
        }
    }
}