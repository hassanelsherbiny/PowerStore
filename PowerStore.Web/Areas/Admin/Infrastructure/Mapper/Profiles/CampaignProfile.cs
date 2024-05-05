using AutoMapper;
using PowerStore.Domain.Messages;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Messages;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class CampaignProfile : Profile, IAutoMapperProfile
    {
        public CampaignProfile()
        {
            CreateMap<Campaign, CampaignModel>()
                .ForMember(dest => dest.CreatedOn, mo => mo.Ignore())
                .ForMember(dest => dest.AllowedTokens, mo => mo.Ignore())
                .ForMember(dest => dest.AvailableStores, mo => mo.Ignore())
                .ForMember(dest => dest.AvailableLanguages, mo => mo.Ignore())
                .ForMember(dest => dest.TestEmail, mo => mo.Ignore());

            CreateMap<CampaignModel, Campaign>()
                .ForMember(dest => dest.Id, mo => mo.Ignore())
                .ForMember(dest => dest.CreatedOnUtc, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}