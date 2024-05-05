using AutoMapper;
using PowerStore.Domain.Messages;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Messages;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class ContactUsProfile : Profile, IAutoMapperProfile
    {
        public ContactUsProfile()
        {
            CreateMap<ContactUs, ContactFormModel>()
                .ForMember(dest => dest.CreatedOn, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}