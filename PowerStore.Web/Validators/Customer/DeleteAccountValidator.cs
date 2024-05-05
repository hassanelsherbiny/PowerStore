using FluentValidation;
using PowerStore.Domain.Customers;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Models.Customer;
using System.Collections.Generic;

namespace PowerStore.Web.Validators.Customer
{
    public class DeleteAccountValidator : BasePowerStoreValidator<DeleteAccountModel>
    {
        public DeleteAccountValidator(
            IEnumerable<IValidatorConsumer<DeleteAccountModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage(localizationService.GetResource("Account.DeleteAccount.Fields.Password.Required"));
        }}
}