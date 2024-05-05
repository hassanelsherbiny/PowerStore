using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Topics;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Topics
{
    public class TopicValidator : BasePowerStoreValidator<TopicModel>
    {
        public TopicValidator(
            IEnumerable<IValidatorConsumer<TopicModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.SystemName).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.Topics.Fields.SystemName.Required"));
        }
    }
}