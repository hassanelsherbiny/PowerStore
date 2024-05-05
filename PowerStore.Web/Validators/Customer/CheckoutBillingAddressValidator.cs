using PowerStore.Domain.Common;
using PowerStore.Core.Validators;
using PowerStore.Services.Directory;
using PowerStore.Services.Localization;
using PowerStore.Web.Models.Checkout;
using PowerStore.Web.Validators.Common;
using System.Collections.Generic;

namespace PowerStore.Web.Validators.Customer
{
    public class CheckoutBillingAddressValidator : BasePowerStoreValidator<CheckoutBillingAddressModel>
    {
        public CheckoutBillingAddressValidator(
            IEnumerable<IValidatorConsumer<CheckoutBillingAddressModel>> validators,
            IEnumerable<IValidatorConsumer<Models.Common.AddressModel>> addressvalidators,
            ILocalizationService localizationService,
            IStateProvinceService stateProvinceService,
            AddressSettings addressSettings)
            : base(validators)
        {
            RuleFor(x => x.NewAddress).SetValidator(new AddressValidator(addressvalidators, localizationService, stateProvinceService, addressSettings));
        }
    }
}
