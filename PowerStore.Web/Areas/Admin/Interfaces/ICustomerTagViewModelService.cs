using PowerStore.Domain.Customers;
using PowerStore.Web.Areas.Admin.Models.Catalog;
using PowerStore.Web.Areas.Admin.Models.Customers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowerStore.Web.Areas.Admin.Interfaces
{
    public interface ICustomerTagViewModelService
    {
        CustomerModel PrepareCustomerModelForList(Customer customer);
        CustomerTagModel PrepareCustomerTagModel();
        Task<CustomerTag> InsertCustomerTagModel(CustomerTagModel model);
        Task<CustomerTag> UpdateCustomerTagModel(CustomerTag customerTag, CustomerTagModel model);
        Task DeleteCustomerTag(CustomerTag customerTag);
        Task<CustomerTagProductModel.AddProductModel> PrepareProductModel(string customerTagId);
        Task<(IList<ProductModel> products, int totalCount)> PrepareProductModel(CustomerTagProductModel.AddProductModel model, int pageIndex, int pageSize);
        Task InsertProductModel(CustomerTagProductModel.AddProductModel model);
    }
}
