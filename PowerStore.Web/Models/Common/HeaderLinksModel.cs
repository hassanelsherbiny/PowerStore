using PowerStore.Core.Models;

namespace PowerStore.Web.Models.Common
{
    public partial class HeaderLinksModel : BaseModel
    {
        public bool IsAuthenticated { get; set; }
        public string CustomerEmailUsername { get; set; }
    }
}