using AutoMapper;
using PowerStore.Domain.Shipping;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Extensions;
using PowerStore.Web.Areas.Admin.Models.Shipping;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class DeliveryDateProfile : Profile, IAutoMapperProfile
    {
        public DeliveryDateProfile()
        {
            CreateMap<DeliveryDate, DeliveryDateModel>()
                .ForMember(dest => dest.Locales, mo => mo.Ignore());

            CreateMap<DeliveryDateModel, DeliveryDate>()
                .ForMember(dest => dest.Id, mo => mo.Ignore())
                .ForMember(dest => dest.Locales, mo => mo.MapFrom(x => x.Locales.ToLocalizedProperty()));
        }

        public int Order => 0;
    }
}