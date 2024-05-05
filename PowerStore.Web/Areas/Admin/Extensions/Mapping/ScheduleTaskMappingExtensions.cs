using PowerStore.Core.Mapper;
using PowerStore.Domain.Tasks;
using PowerStore.Services.Helpers;
using PowerStore.Web.Areas.Admin.Models.Tasks;

namespace PowerStore.Web.Areas.Admin.Extensions.Mapping
{
    public static class ScheduleTaskMappingExtensions
    {
        public static ScheduleTaskModel ToModel(this ScheduleTask entity, IDateTimeHelper dateTimeHelper)
        {
            var taskModel = entity.MapTo<ScheduleTask, ScheduleTaskModel>();
            taskModel.LastStartUtc = entity.LastStartUtc.ConvertToUserTime(dateTimeHelper);
            taskModel.LastSuccessUtc = entity.LastSuccessUtc.ConvertToUserTime(dateTimeHelper);
            taskModel.LastEndUtc = entity.LastNonSuccessEndUtc.ConvertToUserTime(dateTimeHelper);
            return taskModel;

        }

        public static ScheduleTask ToEntity(this ScheduleTaskModel model)
        {
            return model.MapTo<ScheduleTaskModel, ScheduleTask>();
        }

        public static ScheduleTask ToEntity(this ScheduleTaskModel model, ScheduleTask destination)
        {
            return model.MapTo(destination);
        }
    }
}
