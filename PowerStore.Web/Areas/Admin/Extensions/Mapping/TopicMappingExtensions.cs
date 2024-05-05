using PowerStore.Core.Mapper;
using PowerStore.Domain.Topics;
using PowerStore.Services.Helpers;
using PowerStore.Web.Areas.Admin.Models.Topics;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class TopicMappingExtensions
    {
        public static TopicModel ToModel(this Topic entity, IDateTimeHelper dateTimeHelper)
        {
            var topic = entity.MapTo<Topic, TopicModel>();
            topic.StartDateUtc = entity.StartDateUtc.ConvertToUserTime(dateTimeHelper);
            topic.EndDateUtc = entity.EndDateUtc.ConvertToUserTime(dateTimeHelper);
            return topic;
        }

        public static Topic ToEntity(this TopicModel model, IDateTimeHelper dateTimeHelper)
        {
            var topic = model.MapTo<TopicModel, Topic>();
            topic.StartDateUtc = model.StartDateUtc.ConvertToUtcTime(dateTimeHelper);
            topic.EndDateUtc = model.EndDateUtc.ConvertToUtcTime(dateTimeHelper);
            return topic;
        }

        public static Topic ToEntity(this TopicModel model, Topic destination, IDateTimeHelper dateTimeHelper)
        {
            var topic = model.MapTo(destination);
            topic.StartDateUtc = model.StartDateUtc.ConvertToUtcTime(dateTimeHelper);
            topic.EndDateUtc = model.EndDateUtc.ConvertToUtcTime(dateTimeHelper);
            return topic;
        }
    }
}