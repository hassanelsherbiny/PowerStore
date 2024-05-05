using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Messages;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Messages
{
    public class InteractiveFormAttributeValueValidator : BasePowerStoreValidator<InteractiveFormAttributeValueModel>
    {
        public InteractiveFormAttributeValueValidator(
            IEnumerable<IValidatorConsumer<InteractiveFormAttributeValueModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Promotions.InteractiveForms.Attribute.Values.Fields.Name.Required"));
        }
    }
}