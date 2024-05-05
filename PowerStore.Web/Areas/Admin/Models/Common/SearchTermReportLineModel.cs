using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Common
{
    public partial class SearchTermReportLineModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Admin.SearchTermReport.Keyword")]
        public string Keyword { get; set; }

        [PowerStoreResourceDisplayName("Admin.SearchTermReport.Count")]
        public int Count { get; set; }
    }
}
