using PowerStore.Framework.Localization;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Customers
{
    public partial class CustomerAttributeModel : BaseEntityModel, ILocalizedModel<CustomerAttributeLocalizedModel>
    {
        public CustomerAttributeModel()
        {
            Locales = new List<CustomerAttributeLocalizedModel>();
        }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerAttributes.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerAttributes.Fields.IsRequired")]
        public bool IsRequired { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerAttributes.Fields.AttributeControlType")]
        public int AttributeControlTypeId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Customers.CustomerAttributes.Fields.AttributeControlType")]

        public string AttributeControlTypeName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerAttributes.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }


        public IList<CustomerAttributeLocalizedModel> Locales { get; set; }

    }

    public partial class CustomerAttributeLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerAttributes.Fields.Name")]

        public string Name { get; set; }

    }
}