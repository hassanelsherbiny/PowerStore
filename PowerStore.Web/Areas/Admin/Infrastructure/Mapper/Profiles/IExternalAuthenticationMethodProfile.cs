using AutoMapper;
using PowerStore.Core.Mapper;
using PowerStore.Services.Authentication.External;
using PowerStore.Web.Areas.Admin.Models.ExternalAuthentication;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class IExternalAuthenticationMethodProfile : Profile, IAutoMapperProfile
    {
        public IExternalAuthenticationMethodProfile()
        {
            CreateMap<IExternalAuthenticationMethod, AuthenticationMethodModel>()
                .ForMember(dest => dest.FriendlyName, mo => mo.MapFrom(src => src.PluginDescriptor.FriendlyName))
                .ForMember(dest => dest.SystemName, mo => mo.MapFrom(src => src.PluginDescriptor.SystemName))
                .ForMember(dest => dest.DisplayOrder, mo => mo.MapFrom(src => src.PluginDescriptor.DisplayOrder))
                .ForMember(dest => dest.IsActive, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}