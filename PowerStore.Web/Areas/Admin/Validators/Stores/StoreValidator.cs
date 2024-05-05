using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Stores;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Stores
{
    public class StoreValidator : BasePowerStoreValidator<StoreModel>
    {
        public StoreValidator(
            IEnumerable<IValidatorConsumer<StoreModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Stores.Fields.Name.Required"));
            RuleFor(x => x.Shortcut).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Stores.Fields.Shortcut.Required"));
            RuleFor(x => x.Url).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.Stores.Fields.Url.Required"));
        }
    }
}