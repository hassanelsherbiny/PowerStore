using PowerStore.Core.Mapper;
using PowerStore.Domain.News;
using PowerStore.Services.Helpers;
using PowerStore.Web.Areas.Admin.Models.News;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class NewsItemMappingExtensions
    {
        public static NewsItemModel ToModel(this NewsItem entity, IDateTimeHelper dateTimeHelper)
        {
            var newsitem = entity.MapTo<NewsItem, NewsItemModel>();
            newsitem.StartDate = entity.StartDateUtc.ConvertToUserTime(dateTimeHelper);
            newsitem.EndDate = entity.EndDateUtc.ConvertToUserTime(dateTimeHelper);
            return newsitem;
        }

        public static NewsItem ToEntity(this NewsItemModel model, IDateTimeHelper dateTimeHelper)
        {
            var newsitem = model.MapTo<NewsItemModel, NewsItem>();
            newsitem.StartDateUtc = model.StartDate.ConvertToUtcTime(dateTimeHelper);
            newsitem.EndDateUtc = model.EndDate.ConvertToUtcTime(dateTimeHelper);
            return newsitem;
        }

        public static NewsItem ToEntity(this NewsItemModel model, NewsItem destination, IDateTimeHelper dateTimeHelper)
        {
            var newsitem = model.MapTo(destination);
            newsitem.StartDateUtc = model.StartDate.ConvertToUtcTime(dateTimeHelper);
            newsitem.EndDateUtc = model.EndDate.ConvertToUtcTime(dateTimeHelper);
            return newsitem;
        }
    }
}