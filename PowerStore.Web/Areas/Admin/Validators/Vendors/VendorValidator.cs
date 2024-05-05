using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Vendors;
using PowerStore.Web.Areas.Admin.Validators.Common;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Vendors
{
    public class VendorValidator : BasePowerStoreValidator<VendorModel>
    {
        public VendorValidator(
            IEnumerable<IValidatorConsumer<VendorModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Vendors.Fields.Name.Required"));
            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("Admin.Vendors.Fields.Email.Required"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Admin.Common.WrongEmail"));
            RuleFor(x => x.Commission)
                .Must(CommonValid.IsCommissionValid)
                .WithMessage(localizationService.GetResource("Admin.Vendors.Fields.Commission.IsCommissionValid"));
        }
    }
}