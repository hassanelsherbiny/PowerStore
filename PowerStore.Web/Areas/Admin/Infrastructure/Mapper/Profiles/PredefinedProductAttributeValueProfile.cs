using AutoMapper;
using PowerStore.Domain.Catalog;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Extensions;
using PowerStore.Web.Areas.Admin.Models.Catalog;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class PredefinedProductAttributeValueProfile : Profile, IAutoMapperProfile
    {
        public PredefinedProductAttributeValueProfile()
        {
            CreateMap<PredefinedProductAttributeValue, PredefinedProductAttributeValueModel>()
                .ForMember(dest => dest.Locales, mo => mo.Ignore())
                .ForMember(dest => dest.PriceAdjustmentStr, mo => mo.MapFrom(x => x.PriceAdjustment.ToString("N2")))
                .ForMember(dest => dest.WeightAdjustmentStr, mo => mo.MapFrom(x => x.WeightAdjustment.ToString("N2")));

            CreateMap<PredefinedProductAttributeValueModel, PredefinedProductAttributeValue>()
                .ForMember(dest => dest.Id, mo => mo.Ignore())
                .ForMember(dest => dest.Locales, mo => mo.MapFrom(x => x.Locales.ToLocalizedProperty()));
        }

        public int Order => 0;
    }
}