using FluentValidation;
using PowerStore.Api.DTOs.Catalog;
using PowerStore.Core.Validators;
using PowerStore.Services.Catalog;
using PowerStore.Services.Localization;
using System.Collections.Generic;

namespace PowerStore.Api.Validators.Catalog
{
    public class ProductAttributeMappingValidator : BasePowerStoreValidator<ProductAttributeMappingDto>
    {
        public ProductAttributeMappingValidator(
            IEnumerable<IValidatorConsumer<ProductAttributeMappingDto>> validators,
            ILocalizationService localizationService, IProductAttributeService productAttributeService)
            : base(validators)
        {
            RuleFor(x => x).MustAsync(async (x, y, context) =>
            {
                var productattribute = await productAttributeService.GetProductAttributeById(x.ProductAttributeId);
                if (productattribute == null)
                    return false;
                return true;
            }).WithMessage(localizationService.GetResource("Api.Catalog.ProductAttributeMapping.Fields.ProductAttributeId.NotExists"));
        }
    }
}
