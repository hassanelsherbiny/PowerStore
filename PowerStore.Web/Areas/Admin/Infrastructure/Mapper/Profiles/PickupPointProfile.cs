using AutoMapper;
using PowerStore.Domain.Shipping;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Shipping;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class PickupPointProfile : Profile, IAutoMapperProfile
    {
        public PickupPointProfile()
        {
            CreateMap<PickupPoint, PickupPointModel>()
                .ForMember(dest => dest.Address, mo => mo.MapFrom(y => y.Address));

            CreateMap<PickupPointModel, PickupPoint>()
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}