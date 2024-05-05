using FluentValidation;
using PowerStore.Api.DTOs.Catalog;
using PowerStore.Core.Validators;
using PowerStore.Services.Catalog;
using PowerStore.Services.Localization;
using System.Collections.Generic;

namespace PowerStore.Api.Validators.Catalog
{
    public class ProductCategoryValidator : BasePowerStoreValidator<ProductCategoryDto>
    {
        public ProductCategoryValidator(IEnumerable<IValidatorConsumer<ProductCategoryDto>> validators, ILocalizationService localizationService, ICategoryService categoryService)
            : base(validators)
        {
            RuleFor(x => x).MustAsync(async (x, y, context) =>
            {
                var category = await categoryService.GetCategoryById(x.CategoryId);
                if (category == null)
                    return false;
                return true;
            }).WithMessage(localizationService.GetResource("Api.Catalog.ProductCategory.Fields.CategoryId.NotExists"));
        }
    }
}
