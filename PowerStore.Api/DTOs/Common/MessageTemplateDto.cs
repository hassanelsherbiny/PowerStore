using PowerStore.Api.Models;

namespace PowerStore.Api.DTOs.Common
{
    public partial class MessageTemplateDto : BaseApiEntityModel
    {
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public string ViewPath { get; set; }
    }
}
