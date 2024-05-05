using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Installation;
using PowerStore.Web.Models.Install;
using System.Collections.Generic;

namespace PowerStore.Web.Validators.Install
{
    public class InstallValidator : BasePowerStoreValidator<InstallModel>
    {
        public InstallValidator(
            IEnumerable<IValidatorConsumer<InstallModel>> validators,
            IInstallationLocalizationService locService)
            : base(validators)
        {
            RuleFor(x => x.AdminEmail).NotEmpty().WithMessage(locService.GetResource("AdminEmailRequired"));
            RuleFor(x => x.AdminEmail).EmailAddress();
            RuleFor(x => x.AdminPassword).NotEmpty().WithMessage(locService.GetResource("AdminPasswordRequired"));
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage(locService.GetResource("ConfirmPasswordRequired"));
            RuleFor(x => x.AdminPassword).Equal(x => x.ConfirmPassword).WithMessage(locService.GetResource("PasswordsDoNotMatch"));
            
        }
    }
}