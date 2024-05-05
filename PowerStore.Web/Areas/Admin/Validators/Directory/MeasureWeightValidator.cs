using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Directory;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Directory
{
    public class MeasureWeightValidator : BasePowerStoreValidator<MeasureWeightModel>
    {
        public MeasureWeightValidator(
            IEnumerable<IValidatorConsumer<MeasureWeightModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Measures.Weights.Fields.Name.Required"));
            RuleFor(x => x.SystemKeyword).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Measures.Weights.Fields.SystemKeyword.Required"));
        }
    }
}