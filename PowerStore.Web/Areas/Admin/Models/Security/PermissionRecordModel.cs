using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Security
{
    public partial class PermissionRecordModel : BaseModel
    {
        public string Name { get; set; }
        public string SystemName { get; set; }
        public bool Actions { get; set; }
    }
}