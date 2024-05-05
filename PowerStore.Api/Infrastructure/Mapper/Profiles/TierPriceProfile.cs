using AutoMapper;
using PowerStore.Api.DTOs.Catalog;
using PowerStore.Domain.Catalog;
using PowerStore.Core.Mapper;

namespace PowerStore.Api.Infrastructure.Mapper
{
    public class TierPriceProfile : Profile, IAutoMapperProfile
    {
        public TierPriceProfile()
        {
            CreateMap<ProductTierPriceDto, TierPrice>();

            CreateMap<TierPrice, ProductTierPriceDto>();
        }

        public int Order => 1;
    }
}