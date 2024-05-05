using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Customers;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Customers;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Customers
{
    public class UserApiValidator : BasePowerStoreValidator<UserApiModel>
    {
        public UserApiValidator(
            IEnumerable<IValidatorConsumer<UserApiModel>> validators,
            ILocalizationService localizationService, ICustomerService customerService)
            : base(validators)
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Admin.System.UserApi.Email.Required"));
            RuleFor(x => x).MustAsync(async (x, y, context) =>
            {
                if (!string.IsNullOrEmpty(x.Email))
                {
                    var customer = await customerService.GetCustomerByEmail(x.Email.ToLowerInvariant());
                    if (customer != null && customer.Active && !customer.IsSystemAccount)
                        return true;
                }
                return false;
            }).WithMessage(localizationService.GetResource("Admin.System.UserApi.Email.CustomerNotExist")); ;
        }
    }
}