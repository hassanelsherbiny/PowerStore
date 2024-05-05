using AutoMapper;
using PowerStore.Domain.Common;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Settings;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class AddressSettingsProfile : Profile, IAutoMapperProfile
    {
        public AddressSettingsProfile()
        {
            CreateMap<AddressSettings, CustomerUserSettingsModel.AddressSettingsModel>()
                .ForMember(dest => dest.GenericAttributes, mo => mo.Ignore());
            CreateMap<CustomerUserSettingsModel.AddressSettingsModel, AddressSettings>();
        }

        public int Order => 0;
    }
}