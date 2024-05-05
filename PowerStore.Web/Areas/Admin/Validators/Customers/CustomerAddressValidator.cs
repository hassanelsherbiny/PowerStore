using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Customers;
using PowerStore.Web.Areas.Admin.Validators.Common;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Customers
{
    public class CustomerAddressValidator : BasePowerStoreValidator<CustomerAddressModel>
    {
        public CustomerAddressValidator(
            IEnumerable<IValidatorConsumer<CustomerAddressModel>> validators,
            IEnumerable<IValidatorConsumer<Models.Common.AddressModel>> addressvalidators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Address).SetValidator(new AddressValidator(addressvalidators, localizationService));
        }
    }
}
