using FluentValidation;
using PowerStore.Domain.Vendors;
using PowerStore.Core.Validators;
using PowerStore.Services.Directory;
using PowerStore.Services.Localization;
using PowerStore.Web.Models.Vendors;
using PowerStore.Web.Validators.Common;
using System.Collections.Generic;

namespace PowerStore.Web.Validators.Vendors
{
    public class VendorInfoValidator : BasePowerStoreValidator<VendorInfoModel>
    {
        public VendorInfoValidator(
            IEnumerable<IValidatorConsumer<VendorInfoModel>> validators,
            IEnumerable<IValidatorConsumer<VendorAddressModel>> addressvalidators,
            ILocalizationService localizationService, 
            IStateProvinceService stateProvinceService, VendorSettings addressSettings)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Account.VendorInfo.Name.Required"));
            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Account.VendorInfo.Email.Required"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));
            RuleFor(x => x.Address).SetValidator(new VendorAddressValidator(addressvalidators, localizationService, stateProvinceService, addressSettings));
        }
    }
}