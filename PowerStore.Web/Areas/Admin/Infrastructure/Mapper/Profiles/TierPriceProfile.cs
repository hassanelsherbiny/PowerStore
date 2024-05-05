using AutoMapper;
using PowerStore.Domain.Catalog;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Catalog;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class TierPriceProfile : Profile, IAutoMapperProfile
    {
        public TierPriceProfile()
        {
            CreateMap<TierPrice, ProductModel.TierPriceModel>()
                .ForMember(dest => dest.AvailableStores, mo => mo.Ignore())
                .ForMember(dest => dest.AvailableCurrencies, mo => mo.Ignore())
                .ForMember(dest => dest.AvailableCustomerRoles, mo => mo.Ignore());

            CreateMap<ProductModel.TierPriceModel, TierPrice>()
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}