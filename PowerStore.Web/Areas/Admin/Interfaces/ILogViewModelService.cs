using PowerStore.Domain.Logging;
using PowerStore.Web.Areas.Admin.Models.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowerStore.Web.Areas.Admin.Interfaces
{
    public interface ILogViewModelService
    {
        LogListModel PrepareLogListModel();
        Task<(IEnumerable<LogModel> logModels, int totalCount)> PrepareLogModel(LogListModel model, int pageIndex, int pageSize);
        Task<LogModel> PrepareLogModel(Log log);
    }
}
