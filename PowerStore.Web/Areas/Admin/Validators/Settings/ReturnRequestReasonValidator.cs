using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Settings;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Settings
{
    public class ReturnRequestReasonValidator : BasePowerStoreValidator<ReturnRequestReasonModel>
    {
        public ReturnRequestReasonValidator(
            IEnumerable<IValidatorConsumer<ReturnRequestReasonModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Settings.Order.ReturnRequestReasons.Name.Required"));
        }
    }
}