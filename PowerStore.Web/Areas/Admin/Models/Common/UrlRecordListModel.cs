using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Common
{
    public partial class UrlRecordListModel : BaseModel
    {
        public UrlRecordListModel()
        {
            AvailableActiveOptions = new List<SelectListItem>();
        }

        [PowerStoreResourceDisplayName("Admin.System.SeNames.Name")]
        public string SeName { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.SeNames.Active")]
        public int SearchActiveId { get; set; }
        public IList<SelectListItem> AvailableActiveOptions { get; set; }
    }
}