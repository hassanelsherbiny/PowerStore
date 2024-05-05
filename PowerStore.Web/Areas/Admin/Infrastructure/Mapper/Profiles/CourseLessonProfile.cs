using AutoMapper;
using PowerStore.Domain.Courses;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Courses;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class CourseLessonProfile : Profile, IAutoMapperProfile
    {
        public CourseLessonProfile()
        {
            CreateMap<CourseLesson, CourseLessonModel>()
                .ForMember(dest => dest.AvailableSubjects, mo => mo.Ignore());
            CreateMap<CourseLessonModel, CourseLesson>()
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}