using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Messages;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Messages
{
    public class InteractiveFormValidator : BasePowerStoreValidator<InteractiveFormModel>
    {
        public InteractiveFormValidator(
            IEnumerable<IValidatorConsumer<InteractiveFormModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Promotions.InteractiveForms.Fields.Name.Required"));
            RuleFor(x => x.SystemName).NotEmpty().WithMessage(localizationService.GetResource("Admin.Promotions.InteractiveForms.Fields.SystemName.Required"));
            RuleFor(x => x.Body).NotEmpty().WithMessage(localizationService.GetResource("Admin.Promotions.InteractiveForms.Fields.Body.Required"));
        }
    }
}