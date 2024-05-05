using AutoMapper;
using PowerStore.Api.DTOs.Customers;
using PowerStore.Domain.Customers;
using PowerStore.Core.Mapper;

namespace PowerStore.Api.Infrastructure.Mapper
{
    public class CustomerRoleProfile : Profile, IAutoMapperProfile
    {
        public CustomerRoleProfile()
        {

            CreateMap<CustomerRoleDto, CustomerRole>()
                .ForMember(dest => dest.GenericAttributes, mo => mo.Ignore());

            CreateMap<CustomerRole, CustomerRoleDto>();

        }

        public int Order => 1;
    }
}
