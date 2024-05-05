using PowerStore.Framework.Localization;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Messages
{
    public partial class ContactAttributeValueModel : BaseEntityModel, ILocalizedModel<ContactAttributeValueLocalizedModel>
    {
        public ContactAttributeValueModel()
        {
            Locales = new List<ContactAttributeValueLocalizedModel>();
        }

        public string ContactAttributeId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Values.Fields.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Values.Fields.ColorSquaresRgb")]
        public string ColorSquaresRgb { get; set; }
        public bool DisplayColorSquaresRgb { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Values.Fields.IsPreSelected")]
        public bool IsPreSelected { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Values.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<ContactAttributeValueLocalizedModel> Locales { get; set; }

    }

    public partial class ContactAttributeValueLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Values.Fields.Name")]
        public string Name { get; set; }
    }
}