using PowerStore.Core.ModelBinding;

namespace PowerStore.Web.Areas.Admin.Models.Settings
{
    public partial class SortOptionModel
    {
        public virtual int Id { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.Catalog.SortOptions.Name")]
        
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.Catalog.SortOptions.IsActive")]        
        public bool IsActive { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Settings.Catalog.SortOptions.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}