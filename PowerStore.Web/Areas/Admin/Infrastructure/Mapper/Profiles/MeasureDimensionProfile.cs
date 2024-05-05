using AutoMapper;
using PowerStore.Domain.Directory;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Directory;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class MeasureDimensionProfile : Profile, IAutoMapperProfile
    {
        public MeasureDimensionProfile()
        {
            CreateMap<MeasureDimension, MeasureDimensionModel>()
                .ForMember(dest => dest.IsPrimaryDimension, mo => mo.Ignore());

            CreateMap<MeasureDimensionModel, MeasureDimension>()
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}