using PowerStore.Core.Models;

namespace PowerStore.Web.Models.Common
{
    public partial class LogoModel : BaseModel
    {
        public string StoreName { get; set; }

        public string LogoPath { get; set; }
    }
}