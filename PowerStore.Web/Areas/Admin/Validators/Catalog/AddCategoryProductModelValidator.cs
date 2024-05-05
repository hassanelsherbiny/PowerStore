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
    public class AddCategoryProductModelValidator : BasePowerStoreValidator<CategoryModel.AddCategoryProductModel>
    {
        public AddCategoryProductModelValidator(
            IEnumerable<IValidatorConsumer<CategoryModel.AddCategoryProductModel>> validators,
            ILocalizationService localizationService, ICategoryService categoryService, IWorkContext workContext)
            : base(validators)
        {
            if (workContext.CurrentCustomer.IsStaff())
            {
                RuleFor(x => x).MustAsync(async (x, y, context) =>
                {
                    var category = await categoryService.GetCategoryById(x.CategoryId);
                    if (category != null)
                        if (!category.AccessToEntityByStore(workContext.CurrentCustomer.StaffStoreId))
                            return false;

                    return true;
                }).WithMessage(localizationService.GetResource("Admin.Catalog.Categories.Permisions"));
            }
        }
    }
}