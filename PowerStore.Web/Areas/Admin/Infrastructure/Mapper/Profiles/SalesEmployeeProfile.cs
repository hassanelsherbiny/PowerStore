using AutoMapper;
using PowerStore.Core.Mapper;
using PowerStore.Domain.Customers;
using PowerStore.Web.Areas.Admin.Models.Customers;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class SalesEmployeeProfile : Profile, IAutoMapperProfile
    {
        public SalesEmployeeProfile()
        {
            CreateMap<SalesEmployee, SalesEmployeeModel>();

            CreateMap<SalesEmployeeModel, SalesEmployee>()
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}