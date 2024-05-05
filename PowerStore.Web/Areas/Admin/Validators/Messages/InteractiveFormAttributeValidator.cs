using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Messages;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Messages
{
    public class InteractiveFormAttributeValidator : BasePowerStoreValidator<InteractiveFormAttributeModel>
    {
        public InteractiveFormAttributeValidator(
            IEnumerable<IValidatorConsumer<InteractiveFormAttributeModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Promotions.InteractiveForms.Attribute.Fields.Name.Required"));
            RuleFor(x => x.SystemName).NotEmpty().WithMessage(localizationService.GetResource("Admin.Promotions.InteractiveForms.Attribute.Fields.SystemName.Required"));
        }
    }
}