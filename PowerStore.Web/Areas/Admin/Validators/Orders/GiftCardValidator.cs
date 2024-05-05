using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Services.Orders;
using PowerStore.Web.Areas.Admin.Models.Orders;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Orders
{
    public class GiftCardValidator : BasePowerStoreValidator<GiftCardModel>
    {
        public GiftCardValidator(
            IEnumerable<IValidatorConsumer<GiftCardModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.GiftCardCouponCode).NotEmpty().WithMessage(localizationService.GetResource("Admin.GiftCards.Fields.GiftCardCouponCode.Required"));
        }
    }
}