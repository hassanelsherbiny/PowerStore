using PowerStore.Core.Mapper;
using PowerStore.Plugin.Shipping.ShippingPoint.Domain;
using PowerStore.Plugin.Shipping.ShippingPoint.Models;

namespace PowerStore.Plugin.Shipping.ShippingPoint
{
    public static class MappingExtensions
    {
        public static ShippingPointModel ToModel(this ShippingPoints entity)
        {
            return entity.MapTo<ShippingPoints, ShippingPointModel>();
        }

        public static ShippingPoints ToEntity(this ShippingPointModel model)
        {
            return model.MapTo<ShippingPointModel, ShippingPoints>();
        }

        public static ShippingPoints ToEntity(this ShippingPointModel model, ShippingPoints destination)
        {
            return model.MapTo(destination);
        }

    }
}
