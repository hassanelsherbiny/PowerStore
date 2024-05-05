using PowerStore.Core.Mapper;
using PowerStore.Domain.Orders;
using PowerStore.Web.Areas.Admin.Models.Settings;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class ReturnRequestActionMappingExtensions
    {
        public static ReturnRequestActionModel ToModel(this ReturnRequestAction entity)
        {
            return entity.MapTo<ReturnRequestAction, ReturnRequestActionModel>();
        }

        public static ReturnRequestAction ToEntity(this ReturnRequestActionModel model)
        {
            return model.MapTo<ReturnRequestActionModel, ReturnRequestAction>();
        }

        public static ReturnRequestAction ToEntity(this ReturnRequestActionModel model, ReturnRequestAction destination)
        {
            return model.MapTo(destination);
        }
    }
}