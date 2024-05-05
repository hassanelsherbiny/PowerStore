using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Shipping;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Shipping
{
    public class PickupPointValidator : BasePowerStoreValidator<PickupPointModel>
    {
        public PickupPointValidator(
            IEnumerable<IValidatorConsumer<PickupPointModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Shipping.PickupPoints.Fields.Name.Required"));
        }
    }
}