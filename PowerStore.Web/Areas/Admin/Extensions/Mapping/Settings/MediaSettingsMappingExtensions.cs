using PowerStore.Core.Mapper;
using PowerStore.Domain.Media;
using PowerStore.Web.Areas.Admin.Models.Settings;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class MediaSettingsMappingExtensions
    {
        public static MediaSettingsModel ToModel(this MediaSettings entity)
        {
            return entity.MapTo<MediaSettings, MediaSettingsModel>();
        }
        public static MediaSettings ToEntity(this MediaSettingsModel model, MediaSettings destination)
        {
            return model.MapTo(destination);
        }
    }
}