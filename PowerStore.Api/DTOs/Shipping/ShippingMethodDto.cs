using PowerStore.Api.Models;

namespace PowerStore.Api.DTOs.Shipping
{
    public partial class ShippingMethodDto : BaseApiEntityModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
    }
}
