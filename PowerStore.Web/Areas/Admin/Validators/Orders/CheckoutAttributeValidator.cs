using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Orders;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Orders
{
    public class CheckoutAttributeValidator : BasePowerStoreValidator<CheckoutAttributeModel>
    {
        public CheckoutAttributeValidator(
            IEnumerable<IValidatorConsumer<CheckoutAttributeModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.Attributes.CheckoutAttributes.Fields.Name.Required"));
        }
    }
}