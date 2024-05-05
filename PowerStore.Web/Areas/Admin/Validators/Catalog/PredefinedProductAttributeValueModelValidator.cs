using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Catalog;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Catalog
{
    public class PredefinedProductAttributeValueModelValidator : BasePowerStoreValidator<PredefinedProductAttributeValueModel>
    {
        public PredefinedProductAttributeValueModelValidator(
            IEnumerable<IValidatorConsumer<PredefinedProductAttributeValueModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Admin.Catalog.Attributes.ProductAttributes.PredefinedValues.Fields.Name.Required"));
        }
    }
}