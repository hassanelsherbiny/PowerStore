using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Topics
{
    public partial class TopicListModel : BaseModel
    {
        public TopicListModel()
        {
            AvailableStores = new List<SelectListItem>();
        }
        [PowerStoreResourceDisplayName("Admin.ContentManagement.Topics.List.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Topics.List.SearchStore")]
        public string SearchStoreId { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }
    }
}