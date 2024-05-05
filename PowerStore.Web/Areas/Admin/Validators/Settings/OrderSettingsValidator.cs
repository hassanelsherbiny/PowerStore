using FluentValidation;
using PowerStore.Domain.Orders;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Settings;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Settings
{
    public class OrderSettingsValidator : BasePowerStoreValidator<OrderSettingsModel>
    {
        public OrderSettingsValidator(
            IEnumerable<IValidatorConsumer<OrderSettingsModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.GiftCards_Activated_OrderStatusId).NotEqual((int)OrderStatus.Pending)
                .WithMessage(localizationService.GetResource("Admin.Configuration.Settings.RewardPoints.PointsForPurchases_Awarded.Pending"));

            RuleFor(x => x.DaysToCancelUnpaidOrder)
                .GreaterThan(0)
                .When(x => x.DaysToCancelUnpaidOrder.HasValue)
                .WithMessage(localizationService.GetResource("Admin.Configuration.Settings.Order.DaysToCancelUnpaidOrder.Validator"));
        }
    }
}