using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Discounts;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Discounts
{
    public class DiscountValidator : BasePowerStoreValidator<DiscountModel>
    {
        public DiscountValidator(
            IEnumerable<IValidatorConsumer<DiscountModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Promotions.Discounts.Fields.Name.Required"));
            RuleFor(x => x).Must((x, context) =>
            {
                if (x.CalculateByPlugin && string.IsNullOrEmpty(x.DiscountPluginName))
                {
                    return false;
                }
                return true;
            }).WithMessage(localizationService.GetResource("Admin.Promotions.Discounts.Fields.DiscountPluginName.Required"));
        }
    }
}