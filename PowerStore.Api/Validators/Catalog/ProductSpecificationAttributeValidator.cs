using FluentValidation;
using PowerStore.Api.DTOs.Catalog;
using PowerStore.Core.Validators;
using PowerStore.Services.Catalog;
using PowerStore.Services.Localization;
using System.Collections.Generic;

namespace PowerStore.Api.Validators.Catalog
{
    public class ProductSpecificationAttributeValidator : BasePowerStoreValidator<ProductSpecificationAttributeDto>
    {
        public ProductSpecificationAttributeValidator(
            IEnumerable<IValidatorConsumer<ProductSpecificationAttributeDto>> validators,
            ILocalizationService localizationService, ISpecificationAttributeService specificationAttributeService)
            : base(validators)
        {
            RuleFor(x => x).MustAsync(async (x, y, context) =>
            {
                var specification = await specificationAttributeService.GetSpecificationAttributeById(x.SpecificationAttributeId);
                if (specification == null)
                    return false;
                return true;
            }).WithMessage(localizationService.GetResource("Api.Catalog.ProductSpecificationAttribute.Fields.SpecificationAttributeId.NotExists"));

            RuleFor(x => x).MustAsync(async (x, y, context) =>
            {
                if (!string.IsNullOrEmpty(x.SpecificationAttributeOptionId))
                {
                    var sa = await specificationAttributeService.GetSpecificationAttributeByOptionId(x.SpecificationAttributeOptionId);
                    if (sa == null)
                        return false;
                }
                return true;
            }).WithMessage(localizationService.GetResource("Api.Catalog.ProductSpecificationAttribute.Fields.SpecificationAttributeOptionId.NotExists"));
        }
    }
}
