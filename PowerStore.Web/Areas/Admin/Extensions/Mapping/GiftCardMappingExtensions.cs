using PowerStore.Core.Mapper;
using PowerStore.Domain.Orders;
using PowerStore.Web.Areas.Admin.Models.Orders;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class GiftCardMappingExtensions
    {
        public static GiftCardModel ToModel(this GiftCard entity)
        {
            return entity.MapTo<GiftCard, GiftCardModel>();
        }

        public static GiftCard ToEntity(this GiftCardModel model)
        {
            return model.MapTo<GiftCardModel, GiftCard>();
        }

        public static GiftCard ToEntity(this GiftCardModel model, GiftCard destination)
        {
            return model.MapTo(destination);
        }
    }
}