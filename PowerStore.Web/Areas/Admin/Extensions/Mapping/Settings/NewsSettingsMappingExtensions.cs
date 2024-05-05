using PowerStore.Core.Mapper;
using PowerStore.Domain.News;
using PowerStore.Web.Areas.Admin.Models.Settings;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class NewsSettingsMappingExtensions
    {
        public static NewsSettingsModel ToModel(this NewsSettings entity)
        {
            return entity.MapTo<NewsSettings, NewsSettingsModel>();
        }
        public static NewsSettings ToEntity(this NewsSettingsModel model, NewsSettings destination)
        {
            return model.MapTo(destination);
        }
    }
}