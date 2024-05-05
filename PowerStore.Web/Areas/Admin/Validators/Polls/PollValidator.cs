using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Polls;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Polls
{
    public class PollValidator : BasePowerStoreValidator<PollModel>
    {
        public PollValidator(
            IEnumerable<IValidatorConsumer<PollModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.Polls.Fields.Name.Required"));
        }
    }
}