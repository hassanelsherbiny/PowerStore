using PowerStore.Domain.Customers;
using PowerStore.Web.Areas.Admin.Models.Catalog;
using PowerStore.Web.Areas.Admin.Models.Customers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowerStore.Web.Areas.Admin.Interfaces
{
    public interface ICustomerRoleViewModelService
    {
        CustomerRoleModel PrepareCustomerRoleModel(CustomerRole customerRole);
        CustomerRoleModel PrepareCustomerRoleModel();
        Task<CustomerRole> InsertCustomerRoleModel(CustomerRoleModel model);
        Task<CustomerRole> UpdateCustomerRoleModel(CustomerRole customerRole, CustomerRoleModel model);
        Task DeleteCustomerRole(CustomerRole customerRole);
        Task<(IList<ProductModel> products, int totalCount)> PrepareProductModel(CustomerRoleProductModel.AddProductModel model, int pageIndex, int pageSize);
        Task<IList<CustomerRoleProductModel>> PrepareCustomerRoleProductModel(string customerRoleId);
        Task<CustomerRoleProductModel.AddProductModel> PrepareProductModel(string customerRoleId);
        Task InsertProductModel(CustomerRoleProductModel.AddProductModel model);
    }
}
