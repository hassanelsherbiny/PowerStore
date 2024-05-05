using AutoMapper;
using PowerStore.Domain.Orders;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Extensions;
using PowerStore.Web.Areas.Admin.Models.Settings;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class ReturnRequestActionProfile : Profile, IAutoMapperProfile
    {
        public ReturnRequestActionProfile()
        {
            CreateMap<ReturnRequestAction, ReturnRequestActionModel>()
                .ForMember(dest => dest.Locales, mo => mo.Ignore());
            CreateMap<ReturnRequestActionModel, ReturnRequestAction>()
                .ForMember(dest => dest.Locales, mo => mo.MapFrom(x => x.Locales.ToLocalizedProperty()))
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}