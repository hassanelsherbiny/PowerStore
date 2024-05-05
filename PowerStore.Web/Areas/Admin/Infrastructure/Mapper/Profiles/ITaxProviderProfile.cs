using AutoMapper;
using PowerStore.Core.Mapper;
using PowerStore.Services.Tax;
using PowerStore.Web.Areas.Admin.Models.Tax;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class ITaxProviderProfile : Profile, IAutoMapperProfile
    {
        public ITaxProviderProfile()
        {
            CreateMap<ITaxProvider, TaxProviderModel>()
                .ForMember(dest => dest.FriendlyName, mo => mo.MapFrom(src => src.PluginDescriptor.FriendlyName))
                .ForMember(dest => dest.SystemName, mo => mo.MapFrom(src => src.PluginDescriptor.SystemName))
                .ForMember(dest => dest.IsPrimaryTaxProvider, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}