using AutoMapper;
using PowerStore.Domain.Catalog;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Catalog;


namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class ProductReviewProfile : Profile, IAutoMapperProfile
    {
        public ProductReviewProfile()
        {
            CreateMap<ProductReviewModel, ProductReview>()
                .ForMember(dest => dest.HelpfulYesTotal, mo => mo.Ignore())
                .ForMember(dest => dest.HelpfulNoTotal, mo => mo.Ignore())
                .ForMember(dest => dest.CreatedOnUtc, mo => mo.Ignore())
                .ForMember(dest => dest.UpdatedOnUtc, mo => mo.Ignore())
                .ForMember(dest => dest.ProductReviewHelpfulnessEntries, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}