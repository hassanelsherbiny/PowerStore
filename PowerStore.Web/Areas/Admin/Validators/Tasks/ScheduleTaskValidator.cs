using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Tasks;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Tasks
{
    public class ScheduleTaskValidator : BasePowerStoreValidator<ScheduleTaskModel>
    {
        public ScheduleTaskValidator(
            IEnumerable<IValidatorConsumer<ScheduleTaskModel>> validators)
            : base(validators)
        {
            RuleFor(x => x.TimeInterval).GreaterThan(0).WithMessage("Time interval must be greater than zero");
        }
    }
}