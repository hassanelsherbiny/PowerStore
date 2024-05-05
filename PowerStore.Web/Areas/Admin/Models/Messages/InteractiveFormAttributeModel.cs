using PowerStore.Framework.Localization;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Areas.Admin.Models.Messages
{
    public partial class InteractiveFormAttributeModel : BaseEntityModel, ILocalizedModel<InteractiveFormAttributeLocalizedModel>
    {
        public InteractiveFormAttributeModel()
        {
            Locales = new List<InteractiveFormAttributeLocalizedModel>();
        }
        public string FormId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.InteractiveForms.Attribute.Fields.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.InteractiveForms.Attribute.Fields.SystemName")]
        public string SystemName { get; set; }


        [PowerStoreResourceDisplayName("Admin.Promotions.InteractiveForms.Attribute.Fields.RegexValidation")]
        public string RegexValidation { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.InteractiveForms.Attribute.Fields.IsRequired")]
        public bool IsRequired { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.InteractiveForms.Attribute.Fields.FormControlTypeId")]
        public int FormControlTypeId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.InteractiveForms.Attribute.Fields.ValidationMinLength")]
        [UIHint("Int32Nullable")]
        public int? ValidationMinLength { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.InteractiveForms.Attribute.Fields.ValidationMaxLength")]
        [UIHint("Int32Nullable")]
        public int? ValidationMaxLength { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.InteractiveForms.Attribute.Fields.DefaultValue")]
        public string DefaultValue { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.InteractiveForms.Attribute.Fields.Style")]
        public string Style { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.InteractiveForms.Attribute.Fields.Class")]
        public string Class { get; set; }

        public IList<InteractiveFormAttributeLocalizedModel> Locales { get; set; }

    }

    public partial class InteractiveFormAttributeLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Promotions.InteractiveForms.Attribute.Fields.Name")]
        public string Name { get; set; }

    }

}