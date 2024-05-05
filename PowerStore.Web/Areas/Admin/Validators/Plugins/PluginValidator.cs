using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Plugins;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Plugins
{
    public class PluginValidator : BasePowerStoreValidator<PluginModel>
    {
        public PluginValidator(
            IEnumerable<IValidatorConsumer<PluginModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.FriendlyName).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Plugins.Fields.FriendlyName.Required"));
        }
    }
}