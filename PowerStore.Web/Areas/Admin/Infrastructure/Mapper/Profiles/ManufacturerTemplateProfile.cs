using AutoMapper;
using PowerStore.Domain.Catalog;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Templates;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class ManufacturerTemplateProfile : Profile, IAutoMapperProfile
    {
        public ManufacturerTemplateProfile()
        {
            CreateMap<ManufacturerTemplate, ManufacturerTemplateModel>();
            CreateMap<ManufacturerTemplateModel, ManufacturerTemplate>()
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}