using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Tax;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Tax
{
    public class TaxCategoryValidator : BasePowerStoreValidator<TaxCategoryModel>
    {
        public TaxCategoryValidator(
            IEnumerable<IValidatorConsumer<TaxCategoryModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Tax.Categories.Fields.Name.Required"));
        }
    }
}