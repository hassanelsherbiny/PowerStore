using PowerStore.Core.Mapper;
using PowerStore.Core.Plugins;
using PowerStore.Web.Areas.Admin.Models.Plugins;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class PluginDescriptorMappingExtensions
    {
        public static PluginModel ToModel(this PluginDescriptor entity)
        {
            return entity.MapTo<PluginDescriptor, PluginModel>();
        }
    }
}