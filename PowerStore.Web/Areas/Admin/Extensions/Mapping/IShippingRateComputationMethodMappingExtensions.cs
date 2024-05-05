using PowerStore.Core.Mapper;
using PowerStore.Services.Shipping;
using PowerStore.Web.Areas.Admin.Models.Shipping;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class IShippingRateComputationMethodMappingExtensions
    {
        public static ShippingRateComputationMethodModel ToModel(this IShippingRateComputationMethod entity)
        {
            return entity.MapTo<IShippingRateComputationMethod, ShippingRateComputationMethodModel>();
        }
    }
}