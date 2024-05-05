using FluentValidation;
using PowerStore.Core;
using PowerStore.Domain.Customers;
using PowerStore.Core.Validators;
using PowerStore.Services.Catalog;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Extensions;
using PowerStore.Web.Areas.Admin.Models.Catalog;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Catalog
{
    public class ManufacturerProductModelValidator : BasePowerStoreValidator<ManufacturerModel.ManufacturerProductModel>
    {
        public ManufacturerProductModelValidator(
            IEnumerable<IValidatorConsumer<ManufacturerModel.ManufacturerProductModel>> validators,
            ILocalizationService localizationService, IManufacturerService manufacturerService, IWorkContext workContext)
            : base(validators)
        {
            if (workContext.CurrentCustomer.IsStaff())
            {
                RuleFor(x => x).MustAsync(async (x, y, context) =>
                {
                    var manufacturer = await manufacturerService.GetManufacturerById(x.ManufacturerId);
                    if (manufacturer != null)
                        if (!manufacturer.AccessToEntityByStore(workContext.CurrentCustomer.StaffStoreId))
                            return false;

                    return true;
                }).WithMessage(localizationService.GetResource("Admin.Catalog.Manufacturers.Permisions"));
            }
        }
    }
}