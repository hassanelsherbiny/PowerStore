using PowerStore.Domain.Common;
using PowerStore.Core.Validators;
using PowerStore.Services.Directory;
using PowerStore.Services.Localization;
using PowerStore.Web.Models.Customer;
using PowerStore.Web.Validators.Common;
using System.Collections.Generic;

namespace PowerStore.Web.Validators.Customer
{
    public class CustomerAddressEditValidator : BasePowerStoreValidator<CustomerAddressEditModel>
    {
        public CustomerAddressEditValidator(
            IEnumerable<IValidatorConsumer<CustomerAddressEditModel>> validators,
            IEnumerable<IValidatorConsumer<Models.Common.AddressModel>> addressvalidators,
            ILocalizationService localizationService,
            IStateProvinceService stateProvinceService,
            AddressSettings addressSettings)
            : base(validators)
        {
            RuleFor(x => x.Address).SetValidator(new AddressValidator(addressvalidators, localizationService, stateProvinceService, addressSettings));
        }
    }
}
