using AutoMapper;
using PowerStore.Domain.Customers;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Customers;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class CustomerRoleProfile : Profile, IAutoMapperProfile
    {
        public CustomerRoleProfile()
        {
            CreateMap<CustomerRole, CustomerRoleModel>();
            CreateMap<CustomerRoleModel, CustomerRole>()
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}