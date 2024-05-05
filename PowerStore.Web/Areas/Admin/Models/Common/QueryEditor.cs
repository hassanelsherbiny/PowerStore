
using PowerStore.Core.ModelBinding;

namespace PowerStore.Web.Areas.Admin.Models.Common
{
    public partial class QueryEditor
    {
        [PowerStoreResourceDisplayName("Admin.System.Field.QueryEditor")]
        public string Query { get; set; }
    }
}
