using PowerStore.Domain.Tax;
using PowerStore.Core.Models;

namespace PowerStore.Web.Models.Common
{
    public partial class TaxTypeSelectorModel : BaseModel
    {
        public TaxDisplayType CurrentTaxType { get; set; }
    }
}