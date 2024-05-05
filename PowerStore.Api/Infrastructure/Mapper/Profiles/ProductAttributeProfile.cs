using AutoMapper;
using PowerStore.Api.DTOs.Catalog;
using PowerStore.Domain.Catalog;
using PowerStore.Core.Mapper;

namespace PowerStore.Api.Infrastructure.Mapper
{
    public class ProductAttributeProfile : Profile, IAutoMapperProfile
    {
        public ProductAttributeProfile()
        {

            CreateMap<ProductAttributeDto, ProductAttribute>()
                .ForMember(dest => dest.GenericAttributes, mo => mo.Ignore());

            CreateMap<ProductAttribute, ProductAttributeDto>();

            CreateMap<PredefinedProductAttributeValue, PredefinedProductAttributeValueDto>();

            CreateMap<PredefinedProductAttributeValueDto, PredefinedProductAttributeValue>()
                .ForMember(dest => dest.Locales, mo => mo.Ignore());

        }

        public int Order => 1;
    }
}
