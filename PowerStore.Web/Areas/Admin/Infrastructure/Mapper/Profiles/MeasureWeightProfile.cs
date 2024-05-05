using AutoMapper;
using PowerStore.Domain.Directory;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Directory;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class MeasureWeightProfile : Profile, IAutoMapperProfile
    {
        public MeasureWeightProfile()
        {
            CreateMap<MeasureWeight, MeasureWeightModel>()
                .ForMember(dest => dest.IsPrimaryWeight, mo => mo.Ignore());

            CreateMap<MeasureWeightModel, MeasureWeight>()
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}