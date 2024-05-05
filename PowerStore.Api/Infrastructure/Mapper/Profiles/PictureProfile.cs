using AutoMapper;
using PowerStore.Api.DTOs.Common;
using PowerStore.Domain.Media;
using PowerStore.Core.Mapper;

namespace PowerStore.Api.Infrastructure.Mapper
{
    public class PictureProfile : Profile, IAutoMapperProfile
    {
        public PictureProfile()
        {
            CreateMap<PictureDto, Picture>()
                .ForMember(dest => dest.GenericAttributes, mo => mo.Ignore());

            CreateMap<Picture, PictureDto>()
                .ForMember(dest => dest.PictureBinary, mo => mo.Ignore());
        }

        public int Order => 1;
    }
}