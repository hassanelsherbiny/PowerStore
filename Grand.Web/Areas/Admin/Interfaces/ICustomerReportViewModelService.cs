﻿using Grand.Web.Areas.Admin.Models.Customers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Grand.Web.Areas.Admin.Interfaces
{
    public interface ICustomerReportViewModelService
    {
        CustomerReportsModel PrepareCustomerReportsModel();
        Task<IList<RegisteredCustomerReportLineModel>> GetReportRegisteredCustomersModel(string storeId);
        Task<(IEnumerable<BestCustomerReportLineModel> bestCustomerReportLineModels, int totalCount)> PrepareBestCustomerReportLineModel(BestCustomersReportModel model, int orderBy, int pageIndex, int pageSize);
    }
}
