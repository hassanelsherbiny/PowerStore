using AutoMapper;
using PowerStore.Domain.Orders;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Extensions;
using PowerStore.Web.Areas.Admin.Models.Settings;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class ReturnRequestReasonProfile : Profile, IAutoMapperProfile
    {
        public ReturnRequestReasonProfile()
        {
            CreateMap<ReturnRequestReason, ReturnRequestReasonModel>()
                .ForMember(dest => dest.Locales, mo => mo.Ignore());
            CreateMap<ReturnRequestReasonModel, ReturnRequestReason>()
                .ForMember(dest => dest.Locales, mo => mo.MapFrom(x => x.Locales.ToLocalizedProperty()))
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}