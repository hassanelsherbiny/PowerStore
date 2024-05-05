using AutoMapper;
using PowerStore.Domain.Topics;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Templates;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class TopicTemplateProfile : Profile, IAutoMapperProfile
    {
        public TopicTemplateProfile()
        {
            CreateMap<TopicTemplate, TopicTemplateModel>();
            CreateMap<TopicTemplateModel, TopicTemplate>()
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}