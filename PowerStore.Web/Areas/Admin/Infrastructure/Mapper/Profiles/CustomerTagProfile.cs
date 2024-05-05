using AutoMapper;
using PowerStore.Domain.Customers;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Customers;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class CustomerTagProfile : Profile, IAutoMapperProfile
    {
        public CustomerTagProfile()
        {
            CreateMap<CustomerTag, CustomerTagModel>();
            CreateMap<CustomerTagModel, CustomerTag>()
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}