using AutoMapper;
using PowerStore.Domain.Catalog;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Catalog;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class ProductAttributeCombinationProfile : Profile, IAutoMapperProfile
    {
        public ProductAttributeCombinationProfile()
        {
            CreateMap<ProductAttributeCombination, ProductAttributeCombinationModel>()
                .ForMember(dest => dest.UseMultipleWarehouses, mo => mo.Ignore())
                .ForMember(dest => dest.PrimaryStoreCurrencyCode, mo => mo.Ignore())
                .ForMember(dest => dest.WarehouseInventoryModels, mo => mo.Ignore());
            CreateMap<ProductAttributeCombinationModel, ProductAttributeCombination>()
                .ForMember(dest => dest.WarehouseInventory, mo => mo.Ignore())
                .ForMember(dest => dest.Id, mo => mo.Ignore());

            CreateMap<PredefinedProductAttributeValue, ProductAttributeValue>()
               .ForMember(dest => dest.AttributeValueType, mo => mo.MapFrom(x => AttributeValueType.Simple))
               .ForMember(dest => dest.ProductAttributeMappingId, mo => mo.MapFrom(x => x.Id))
               .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}