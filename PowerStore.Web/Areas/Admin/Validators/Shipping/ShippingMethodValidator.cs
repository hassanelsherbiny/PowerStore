using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Shipping;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Shipping
{
    public class ShippingMethodValidator : BasePowerStoreValidator<ShippingMethodModel>
    {
        public ShippingMethodValidator(
            IEnumerable<IValidatorConsumer<ShippingMethodModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Shipping.Methods.Fields.Name.Required"));
        }
    }
}