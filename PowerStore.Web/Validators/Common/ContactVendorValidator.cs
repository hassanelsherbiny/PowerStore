using FluentValidation;
using PowerStore.Domain.Common;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Models.Common;
using System.Collections.Generic;

namespace PowerStore.Web.Validators.Common
{
    public class ContactVendorValidator : BasePowerStoreValidator<ContactVendorModel>
    {
        public ContactVendorValidator(
            IEnumerable<IValidatorConsumer<ContactVendorModel>> validators,
            ILocalizationService localizationService, CommonSettings commonSettings)
            : base(validators)
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage(localizationService.GetResource("ContactVendor.Email.Required"));
            RuleFor(x => x.Email).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));
            RuleFor(x => x.FullName).NotEmpty().WithMessage(localizationService.GetResource("ContactVendor.FullName.Required"));
            if (commonSettings.SubjectFieldOnContactUsForm)
            {
                RuleFor(x => x.Subject).NotEmpty().WithMessage(localizationService.GetResource("ContactVendor.Subject.Required"));
            }
            RuleFor(x => x.Enquiry).NotEmpty().WithMessage(localizationService.GetResource("ContactVendor.Enquiry.Required"));
        }}
}