using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Cms
{
    public partial class RenderWidgetModel : BaseModel
    {
        public string WidgetViewComponentName { get; set; }
        public object WidgetViewComponentArguments { get; set; }
    }
}