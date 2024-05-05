using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Messages;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Messages
{
    public class ContactAttributeValueValidator : BasePowerStoreValidator<ContactAttributeValueModel>
    {
        public ContactAttributeValueValidator(
            IEnumerable<IValidatorConsumer<ContactAttributeValueModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.Attributes.ContactAttributes.Values.Fields.Name.Required"));
        }
    }
}