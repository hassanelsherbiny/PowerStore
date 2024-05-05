using PowerStore.Framework.Localization;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.Collections.Generic;
using PowerStore.Framework.Mvc.Models;
using PowerStore.Framework.Mapping;

namespace PowerStore.Web.Areas.Admin.Models.Catalog
{
    public partial class SpecificationAttributeModel : BaseEntityModel, ILocalizedModel<SpecificationAttributeLocalizedModel>, IStoreMappingModel
    {
        public SpecificationAttributeModel()
        {
            Locales = new List<SpecificationAttributeLocalizedModel>();
        }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.SpecificationAttributes.Fields.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.SpecificationAttributes.Fields.SeName")]
        public string SeName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.SpecificationAttributes.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        //Store mapping
        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Categories.Fields.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }
        public string[] SelectedStoreIds { get; set; }

        public IList<SpecificationAttributeLocalizedModel> Locales { get; set; }

    }

    public partial class SpecificationAttributeLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.SpecificationAttributes.Fields.Name")]
        public string Name { get; set; }
    }
}