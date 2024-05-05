using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Messages;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Messages
{
    public class ContactAttributeValidator : BasePowerStoreValidator<ContactAttributeModel>
    {
        public ContactAttributeValidator(
            IEnumerable<IValidatorConsumer<ContactAttributeModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.Attributes.ContactAttributes.Fields.Name.Required"));
        }
    }
}