using PowerStore.Api.Models;

namespace PowerStore.Api.DTOs.Shipping
{
    public partial class WarehouseDto : BaseApiEntityModel
    {
        public string Name { get; set; }
        public string AdminComment { get; set; }
    }
}
