using PowerStore.Core.Mapper;
using PowerStore.Domain.Discounts;
using PowerStore.Services.Helpers;
using PowerStore.Web.Areas.Admin.Models.Discounts;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class DiscountMappingExtensions
    {
        public static DiscountModel ToModel(this Discount entity, IDateTimeHelper dateTimeHelper)
        {
            var discount = entity.MapTo<Discount, DiscountModel>();
            discount.StartDate = entity.StartDateUtc.ConvertToUserTime(dateTimeHelper);
            discount.EndDate = entity.EndDateUtc.ConvertToUserTime(dateTimeHelper);
            return discount;
        }

        public static Discount ToEntity(this DiscountModel model, IDateTimeHelper dateTimeHelper)
        {
            var discount = model.MapTo<DiscountModel, Discount>();
            discount.StartDateUtc = model.StartDate.ConvertToUtcTime(dateTimeHelper);
            discount.EndDateUtc = model.EndDate.ConvertToUtcTime(dateTimeHelper);
            return discount;
        }

        public static Discount ToEntity(this DiscountModel model, Discount destination, IDateTimeHelper dateTimeHelper)
        {
            var discount = model.MapTo(destination);
            discount.StartDateUtc = model.StartDate.ConvertToUtcTime(dateTimeHelper);
            discount.EndDateUtc = model.EndDate.ConvertToUtcTime(dateTimeHelper);
            return discount;
        }
    }
}