using AutoMapper;
using PowerStore.Domain.Tax;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Tax;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class TaxCategoryProfile : Profile, IAutoMapperProfile
    {
        public TaxCategoryProfile()
        {
            CreateMap<TaxCategory, TaxCategoryModel>();
            CreateMap<TaxCategoryModel, TaxCategory>()
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}