using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Directory;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Directory
{
    public class MeasureDimensionValidator : BasePowerStoreValidator<MeasureDimensionModel>
    {
        public MeasureDimensionValidator(
            IEnumerable<IValidatorConsumer<MeasureDimensionModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Measures.Dimensions.Fields.Name.Required"));
            RuleFor(x => x.SystemKeyword).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Measures.Dimensions.Fields.SystemKeyword.Required"));
        }
    }
}