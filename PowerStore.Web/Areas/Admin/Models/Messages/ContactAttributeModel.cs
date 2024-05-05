using PowerStore.Domain.Catalog;
using PowerStore.Framework.Localization;
using PowerStore.Framework.Mapping;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PowerStore.Framework.Mvc.Models;

namespace PowerStore.Web.Areas.Admin.Models.Messages
{
    public partial class ContactAttributeModel : BaseEntityModel, ILocalizedModel<ContactAttributeLocalizedModel>, IAclMappingModel, IStoreMappingModel
    {
        public ContactAttributeModel()
        {
            Locales = new List<ContactAttributeLocalizedModel>();
            AvailableCustomerRoles = new List<CustomerRoleModel>();
            AvailableStores = new List<StoreModel>();
        }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Fields.TextPrompt")]

        public string TextPrompt { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Fields.IsRequired")]
        public bool IsRequired { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Fields.AttributeControlType")]
        public int AttributeControlTypeId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Fields.AttributeControlType")]

        public string AttributeControlTypeName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }


        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Fields.MinLength")]
        [UIHint("Int32Nullable")]
        public int? ValidationMinLength { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Fields.MaxLength")]
        [UIHint("Int32Nullable")]
        public int? ValidationMaxLength { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Fields.FileAllowedExtensions")]
        public string ValidationFileAllowedExtensions { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Fields.FileMaximumSize")]
        [UIHint("Int32Nullable")]
        public int? ValidationFileMaximumSize { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Fields.DefaultValue")]
        public string DefaultValue { get; set; }

        public IList<ContactAttributeLocalizedModel> Locales { get; set; }

        //condition
        public bool ConditionAllowed { get; set; }
        public ConditionModel ConditionModel { get; set; }

        //Store mapping
        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Fields.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Fields.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }
        public string[] SelectedStoreIds { get; set; }

        //ACL
        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Fields.SubjectToAcl")]
        public bool SubjectToAcl { get; set; }
        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Fields.AclCustomerRoles")]
        public List<CustomerRoleModel> AvailableCustomerRoles { get; set; }
        public string[] SelectedCustomerRoleIds { get; set; }
    }

    public partial class ConditionModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Condition.EnableCondition")]
        public bool EnableCondition { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Condition.Attributes")]
        public string SelectedAttributeId { get; set; }

        public IList<AttributeConditionModel> ConditionAttributes { get; set; }
    }
    public partial class AttributeConditionModel : BaseEntityModel
    {
        public string Name { get; set; }

        public AttributeControlType AttributeControlType { get; set; }

        public IList<SelectListItem> Values { get; set; }

        public string SelectedValueId { get; set; }
    }
    public partial class ContactAttributeLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Catalog.Attributes.ContactAttributes.Fields.TextPrompt")]

        public string TextPrompt { get; set; }

    }
}