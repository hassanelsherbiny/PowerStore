using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Courses;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Courses
{
    public class CourseLevelValidator : BasePowerStoreValidator<CourseLevelModel>
    {
        public CourseLevelValidator(
            IEnumerable<IValidatorConsumer<CourseLevelModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Courses.Level.Fields.Name.Required"));
        }
    }
}