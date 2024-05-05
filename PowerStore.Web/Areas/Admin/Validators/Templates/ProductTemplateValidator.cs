using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Templates;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Templates
{
    public class ProductTemplateValidator : BasePowerStoreValidator<ProductTemplateModel>
    {
        public ProductTemplateValidator(
            IEnumerable<IValidatorConsumer<ProductTemplateModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.System.Templates.Product.Name.Required"));
            RuleFor(x => x.ViewPath).NotEmpty().WithMessage(localizationService.GetResource("Admin.System.Templates.Product.ViewPath.Required"));
        }
    }
}