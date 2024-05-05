using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Templates;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Templates
{
    public class TopicTemplateValidator : BasePowerStoreValidator<TopicTemplateModel>
    {
        public TopicTemplateValidator(
            IEnumerable<IValidatorConsumer<TopicTemplateModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.System.Templates.Topic.Name.Required"));
            RuleFor(x => x.ViewPath).NotEmpty().WithMessage(localizationService.GetResource("Admin.System.Templates.Topic.ViewPath.Required"));
        }
    }
}