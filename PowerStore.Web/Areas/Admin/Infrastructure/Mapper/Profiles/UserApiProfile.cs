using AutoMapper;
using PowerStore.Domain.Customers;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Customers;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class UserApiProfile : Profile, IAutoMapperProfile
    {
        public UserApiProfile()
        {
            CreateMap<UserApi, UserApiModel>()
                .ForMember(dest => dest.Password, mo => mo.Ignore());
            CreateMap<UserApiModel, UserApi>()
                .ForMember(dest => dest.Password, mo => mo.Ignore())
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}