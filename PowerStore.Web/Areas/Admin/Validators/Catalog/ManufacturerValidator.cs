using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Catalog;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Catalog
{
    public class ManufacturerValidator : BasePowerStoreValidator<ManufacturerModel>
    {
        public ManufacturerValidator(
            IEnumerable<IValidatorConsumer<ManufacturerModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Catalog.Manufacturers.Fields.Name.Required"));
        }
    }
}
