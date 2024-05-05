using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Messages;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Messages
{
    public class EmailAccountValidator : BasePowerStoreValidator<EmailAccountModel>
    {
        public EmailAccountValidator(
            IEnumerable<IValidatorConsumer<EmailAccountModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.EmailAccounts.Fields.Email"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Admin.Common.WrongEmail"));
            RuleFor(x => x.DisplayName).NotEmpty().WithMessage(localizationService.GetResource("Admin.Configuration.EmailAccounts.Fields.DisplayName"));
        }
    }
}