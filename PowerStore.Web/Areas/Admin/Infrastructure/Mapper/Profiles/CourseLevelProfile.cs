using AutoMapper;
using PowerStore.Domain.Courses;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Courses;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class CourseLevelProfile : Profile, IAutoMapperProfile
    {
        public CourseLevelProfile()
        {
            CreateMap<CourseLevel, CourseLevelModel>();
            CreateMap<CourseLevelModel, CourseLevel>()
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}