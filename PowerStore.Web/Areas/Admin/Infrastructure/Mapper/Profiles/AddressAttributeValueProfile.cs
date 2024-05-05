using AutoMapper;
using PowerStore.Domain.Common;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Extensions;
using PowerStore.Web.Areas.Admin.Models.Common;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class AddressAttributeValueProfile : Profile, IAutoMapperProfile
    {
        public AddressAttributeValueProfile()
        {
            CreateMap<AddressAttributeValue, AddressAttributeValueModel>()
                .ForMember(dest => dest.Locales, mo => mo.Ignore());
            CreateMap<AddressAttributeValueModel, AddressAttributeValue>()
                .ForMember(dest => dest.Id, mo => mo.Ignore())
                .ForMember(dest => dest.Locales, mo => mo.MapFrom(x => x.Locales.ToLocalizedProperty()));
        }

        public int Order => 0;
    }
}