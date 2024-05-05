using AutoMapper;
using PowerStore.Domain.Shipping;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Extensions;
using PowerStore.Web.Areas.Admin.Models.Shipping;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class ShippingMethodProfile : Profile, IAutoMapperProfile
    {
        public ShippingMethodProfile()
        {
            CreateMap<ShippingMethod, ShippingMethodModel>()
                .ForMember(dest => dest.Locales, mo => mo.Ignore());

            CreateMap<ShippingMethodModel, ShippingMethod>()
                .ForMember(dest => dest.Id, mo => mo.Ignore())
                .ForMember(dest => dest.Locales, mo => mo.MapFrom(x => x.Locales.ToLocalizedProperty()))
                .ForMember(dest => dest.RestrictedCountries, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}