using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Models.Customer;
using System.Collections.Generic;

namespace PowerStore.Web.Validators.Customer
{
    public class PasswordRecoveryValidator : BasePowerStoreValidator<PasswordRecoveryModel>
    {
        public PasswordRecoveryValidator(
            IEnumerable<IValidatorConsumer<PasswordRecoveryModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Account.PasswordRecovery.Email.Required"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));
        }}
}