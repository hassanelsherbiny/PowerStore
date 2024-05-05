using System.ComponentModel.DataAnnotations;

namespace PowerStore.Api.DTOs.Catalog
{
    public partial class ProductCategoryDto
    {
        [Key]
        public string CategoryId { get; set; }
        public bool IsFeaturedProduct { get; set; }
    }
}
