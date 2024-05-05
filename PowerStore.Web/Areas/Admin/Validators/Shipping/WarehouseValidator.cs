using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Shipping;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Shipping
{
    public class WarehouseValidator : BasePowerStoreValidator<WarehouseModel>
    {
        public WarehouseValidator(
            IEnumerable<IValidatorConsumer<WarehouseModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Shipping.Warehouses.Fields.Name.Required"));
        }
    }
}