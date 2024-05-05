using AutoMapper;
using PowerStore.Core.Mapper;
using PowerStore.Core.Plugins;
using PowerStore.Web.Areas.Admin.Models.Plugins;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class PluginDescriptorProfile : Profile, IAutoMapperProfile
    {
        public PluginDescriptorProfile()
        {
            CreateMap<PluginDescriptor, PluginModel>()
                .ForMember(dest => dest.ConfigurationUrl, mo => mo.Ignore())
                .ForMember(dest => dest.CanChangeEnabled, mo => mo.Ignore())
                .ForMember(dest => dest.IsEnabled, mo => mo.Ignore())
                .ForMember(dest => dest.LogoUrl, mo => mo.Ignore())
                .ForMember(dest => dest.LimitedToStores, mo => mo.Ignore())
                .ForMember(dest => dest.AvailableStores, mo => mo.Ignore())
                .ForMember(dest => dest.SelectedStoreIds, mo => mo.Ignore())
                .ForMember(dest => dest.Locales, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}