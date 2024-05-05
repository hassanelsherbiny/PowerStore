using System;

namespace PowerStore.Domain.Catalog
{
    public partial class ProductDeleted: Product
    {
        public DateTime DeletedOnUtc { get; set; }
    }
}
