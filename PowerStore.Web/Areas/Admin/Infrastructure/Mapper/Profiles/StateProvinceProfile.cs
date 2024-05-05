using AutoMapper;
using PowerStore.Domain.Directory;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Extensions;
using PowerStore.Web.Areas.Admin.Models.Directory;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class StateProvinceProfile : Profile, IAutoMapperProfile
    {
        public StateProvinceProfile()
        {
            CreateMap<StateProvince, StateProvinceModel>()
                .ForMember(dest => dest.Locales, mo => mo.Ignore());
            CreateMap<StateProvinceModel, StateProvince>()
                .ForMember(dest => dest.Id, mo => mo.Ignore())
                .ForMember(dest => dest.Locales, mo => mo.MapFrom(x => x.Locales.ToLocalizedProperty()));
        }

        public int Order => 0;
    }
}