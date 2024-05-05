using PowerStore.Core.Mapper;
using AutoMapper;
using PowerStore.Plugin.Shipping.ShippingPoint.Domain;
using PowerStore.Plugin.Shipping.ShippingPoint.Models;

namespace PowerStore.Plugin.Shipping.ShippingPoint
{
    public class MapperConfiguration : Profile, IAutoMapperProfile
    {
        public int Order
        {
           get { return 0; }
        }

        public MapperConfiguration()
        {
            CreateMap<ShippingPoints, ShippingPointModel>()
            .ForMember(dest => dest.AvailableStores, mo => mo.Ignore())
            .ForMember(dest => dest.StoreName, mo => mo.Ignore())
            .ForMember(dest => dest.AvailableCountries, mo => mo.Ignore())
            .ForMember(dest => dest.GenericAttributes, mo => mo.Ignore());

            CreateMap<ShippingPointModel, ShippingPoints>();                
        }
    }
}
