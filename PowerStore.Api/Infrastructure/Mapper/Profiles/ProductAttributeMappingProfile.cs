using AutoMapper;
using PowerStore.Api.DTOs.Catalog;
using PowerStore.Domain.Catalog;
using PowerStore.Core.Mapper;

namespace PowerStore.Api.Infrastructure.Mapper
{
    public class ProductAttributeMappingProfile : Profile, IAutoMapperProfile
    {
        public ProductAttributeMappingProfile()
        {
            CreateMap<ProductAttributeMappingDto, ProductAttributeMapping>();
            CreateMap<ProductAttributeMapping, ProductAttributeMappingDto>();

            CreateMap<ProductAttributeValueDto, ProductAttributeValue>();
            CreateMap<ProductAttributeValue, ProductAttributeValueDto>();
        }

        public int Order => 1;
    }
}
