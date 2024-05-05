using FluentValidation;
using PowerStore.Api.DTOs.Catalog;
using PowerStore.Core.Validators;
using PowerStore.Services.Catalog;
using PowerStore.Services.Localization;
using System.Collections.Generic;

namespace PowerStore.Api.Validators.Catalog
{
    public class ProductManufacturerValidator : BasePowerStoreValidator<ProductManufacturerDto>
    {
        public ProductManufacturerValidator(IEnumerable<IValidatorConsumer<ProductManufacturerDto>> validators, ILocalizationService localizationService, IManufacturerService manufacturerService)
            : base(validators)
        {
            RuleFor(x => x).MustAsync(async (x, y, context) =>
            {
                var manufacturer = await manufacturerService.GetManufacturerById(x.ManufacturerId);
                if (manufacturer == null)
                    return false;
                return true;
            }).WithMessage(localizationService.GetResource("Api.Catalog.ProductManufacturer.Fields.ManufacturerId.NotExists"));
        }
    }
}
