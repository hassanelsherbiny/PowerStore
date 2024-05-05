using PowerStore.Core.Models;

namespace PowerStore.Web.Models.Common
{
    public partial class CurrencyModel : BaseEntityModel
    {
        public string Name { get; set; }

        public string CurrencySymbol { get; set; }
        public string CurrencyCode { get; set; }
    }
}