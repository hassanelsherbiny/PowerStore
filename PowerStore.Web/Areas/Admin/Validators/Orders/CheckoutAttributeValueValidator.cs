using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Orders;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Orders
{
    public class CheckoutAttributeValueValidator : BasePowerStoreValidator<CheckoutAttributeValueModel>
    {
        public CheckoutAttributeValueValidator(
            IEnumerable<IValidatorConsumer<CheckoutAttributeValueModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.Attributes.CheckoutAttributes.Values.Fields.Name.Required"));
        }
    }
}