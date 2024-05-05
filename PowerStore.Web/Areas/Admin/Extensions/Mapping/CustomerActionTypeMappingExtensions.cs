using PowerStore.Core.Mapper;
using PowerStore.Domain.Customers;
using PowerStore.Web.Areas.Admin.Models.Customers;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class CustomerActionTypeMappingExtensions
    {
        public static CustomerActionTypeModel ToModel(this CustomerActionType entity)
        {
            return entity.MapTo<CustomerActionType, CustomerActionTypeModel>();
        }
    }
}