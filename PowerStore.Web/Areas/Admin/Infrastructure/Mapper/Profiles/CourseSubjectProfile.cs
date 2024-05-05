using AutoMapper;
using PowerStore.Domain.Courses;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Courses;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class CourseSubjectProfile : Profile, IAutoMapperProfile
    {
        public CourseSubjectProfile()
        {
            CreateMap<CourseSubject, CourseSubjectModel>();
            CreateMap<CourseSubjectModel, CourseSubject>()
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}