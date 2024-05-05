using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Directory;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Directory
{
    public class MeasureUnitValidator : BasePowerStoreValidator<MeasureUnitModel>
    {
        public MeasureUnitValidator(
            IEnumerable<IValidatorConsumer<MeasureUnitModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Measures.Units.Fields.Name.Required"));
        }
    }
}