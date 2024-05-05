using AutoMapper;
using PowerStore.Domain.Logging;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Logging;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class ActivityLogTypeProfile : Profile, IAutoMapperProfile
    {
        public ActivityLogTypeProfile()
        {
            CreateMap<ActivityLogTypeModel, ActivityLogType>()
                .ForMember(dest => dest.Id, mo => mo.Ignore())
                .ForMember(dest => dest.SystemKeyword, mo => mo.Ignore());

            CreateMap<ActivityLogType, ActivityLogTypeModel>();

            CreateMap<ActivityLog, ActivityLogModel>()
                .ForMember(dest => dest.CreatedOn, mo => mo.Ignore());

            CreateMap<ActivityStats, ActivityStatsModel>()
                .ForMember(dest => dest.ActivityLogTypeName, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}