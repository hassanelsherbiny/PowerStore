using FluentValidation;
using PowerStore.Domain.Orders;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Settings;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Settings
{
    public class RewardPointsSettingsValidator : BasePowerStoreValidator<RewardPointsSettingsModel>
    {
        public RewardPointsSettingsValidator(
            IEnumerable<IValidatorConsumer<RewardPointsSettingsModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.PointsForPurchases_Awarded).NotEqual((int)OrderStatus.Pending).WithMessage(localizationService.GetResource("Admin.Configuration.Settings.RewardPoints.PointsForPurchases_Awarded.Pending"));
        }
    }
}