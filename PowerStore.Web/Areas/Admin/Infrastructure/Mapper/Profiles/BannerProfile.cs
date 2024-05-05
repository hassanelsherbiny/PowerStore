using AutoMapper;
using PowerStore.Domain.Messages;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Extensions;
using PowerStore.Web.Areas.Admin.Models.Messages;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class BannerProfile : Profile, IAutoMapperProfile
    {
        public BannerProfile()
        {
            CreateMap<Banner, BannerModel>()
                .ForMember(dest => dest.Locales, mo => mo.Ignore());

            CreateMap<BannerModel, Banner>()
                .ForMember(dest => dest.Id, mo => mo.Ignore())
                .ForMember(dest => dest.Locales, mo => mo.MapFrom(x => x.Locales.ToLocalizedProperty()));
        }

        public int Order => 0;
    }
}