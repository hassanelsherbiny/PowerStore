using AutoMapper;
using PowerStore.Domain.Orders;
using PowerStore.Core.Mapper;
using PowerStore.Web.Areas.Admin.Models.Orders;

namespace PowerStore.Web.Areas.Admin.Infrastructure.Mapper.Profiles
{
    public class GiftCardProfile : Profile, IAutoMapperProfile
    {
        public GiftCardProfile()
        {
            CreateMap<GiftCard, GiftCardModel>()
                .ForMember(dest => dest.PurchasedWithOrderId, mo => mo.Ignore())
                .ForMember(dest => dest.AmountStr, mo => mo.Ignore())
                .ForMember(dest => dest.RemainingAmountStr, mo => mo.Ignore())
                .ForMember(dest => dest.AvailableCurrencies, mo => mo.Ignore())
                .ForMember(dest => dest.CreatedOn, mo => mo.Ignore());
            CreateMap<GiftCardModel, GiftCard>()
                .ForMember(dest => dest.Id, mo => mo.Ignore())
                .ForMember(dest => dest.GiftCardType, mo => mo.Ignore())
                .ForMember(dest => dest.GiftCardUsageHistory, mo => mo.Ignore())
                .ForMember(dest => dest.PurchasedWithOrderItem, mo => mo.Ignore())
                .ForMember(dest => dest.IsRecipientNotified, mo => mo.Ignore())
                .ForMember(dest => dest.CreatedOnUtc, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}