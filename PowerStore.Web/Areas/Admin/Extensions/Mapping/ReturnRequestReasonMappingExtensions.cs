using PowerStore.Core.Mapper;
using PowerStore.Domain.Orders;
using PowerStore.Web.Areas.Admin.Models.Settings;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class ReturnRequestReasonMappingExtensions
    {
        public static ReturnRequestReasonModel ToModel(this ReturnRequestReason entity)
        {
            return entity.MapTo<ReturnRequestReason, ReturnRequestReasonModel>();
        }

        public static ReturnRequestReason ToEntity(this ReturnRequestReasonModel model)
        {
            return model.MapTo<ReturnRequestReasonModel, ReturnRequestReason>();
        }

        public static ReturnRequestReason ToEntity(this ReturnRequestReasonModel model, ReturnRequestReason destination)
        {
            return model.MapTo(destination);
        }
    }
}