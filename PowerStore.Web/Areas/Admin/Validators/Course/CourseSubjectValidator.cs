using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Courses;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Courses
{
    public class CourseSubjectValidator : BasePowerStoreValidator<CourseSubjectModel>
    {
        public CourseSubjectValidator(
            IEnumerable<IValidatorConsumer<CourseSubjectModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Courses.Course.Subject.Fields.Name.Required"));
            RuleFor(x => x.CourseId).NotEmpty().WithMessage(localizationService.GetResource("Admin.Courses.Course.Subject.Fields.CourseId.Required"));
        }
    }
}