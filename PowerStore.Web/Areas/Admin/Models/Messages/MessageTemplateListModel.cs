using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Messages
{
    public partial class MessageTemplateListModel : BaseModel
    {
        public MessageTemplateListModel()
        {
            AvailableStores = new List<SelectListItem>();
        }
        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.List.Name")]
        public string Name { get; set; }
        [PowerStoreResourceDisplayName("Admin.ContentManagement.MessageTemplates.List.SearchStore")]
        public string SearchStoreId { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }
    }
}