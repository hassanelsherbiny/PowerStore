using AutoMapper;
using PowerStore.Domain.Directory;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Directory;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class MeasureUnitProfile : Profile, IAutoMapperProfile
    {
        public MeasureUnitProfile()
        {
            CreateMap<MeasureUnit, MeasureUnitModel>();
            CreateMap<MeasureUnitModel, MeasureUnit>()
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}