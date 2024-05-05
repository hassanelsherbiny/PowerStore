using PowerStore.Framework.Localization;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Common
{
    public partial class AddressAttributeModel : BaseEntityModel, ILocalizedModel<AddressAttributeLocalizedModel>
    {
        public AddressAttributeModel()
        {
            Locales = new List<AddressAttributeLocalizedModel>();
        }

        [PowerStoreResourceDisplayName("Admin.Address.AddressAttributes.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Address.AddressAttributes.Fields.IsRequired")]
        public bool IsRequired { get; set; }

        [PowerStoreResourceDisplayName("Admin.Address.AddressAttributes.Fields.AttributeControlType")]
        public int AttributeControlTypeId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Address.AddressAttributes.Fields.AttributeControlType")]

        public string AttributeControlTypeName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Address.AddressAttributes.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }


        public IList<AddressAttributeLocalizedModel> Locales { get; set; }

    }

    public partial class AddressAttributeLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Address.AddressAttributes.Fields.Name")]

        public string Name { get; set; }

    }
}