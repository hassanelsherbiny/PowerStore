using PowerStore.Core.Mapper;
using PowerStore.Domain.Customers;
using PowerStore.Web.Areas.Admin.Models.Customers;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class SalesEmployeeMappingExtensions
    {
        public static SalesEmployeeModel ToModel(this SalesEmployee entity)
        {
            return entity.MapTo<SalesEmployee, SalesEmployeeModel>();
        }

        public static SalesEmployee ToEntity(this SalesEmployeeModel model)
        {
            return model.MapTo<SalesEmployeeModel, SalesEmployee>();
        }

        public static SalesEmployee ToEntity(this SalesEmployeeModel model, SalesEmployee destination)
        {
            return model.MapTo(destination);
        }
    }
}