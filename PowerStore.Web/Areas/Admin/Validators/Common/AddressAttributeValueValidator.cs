using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Common;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Common
{
    public class AddressAttributeValueValidator : BasePowerStoreValidator<AddressAttributeValueModel>
    {
        public AddressAttributeValueValidator(
            IEnumerable<IValidatorConsumer<AddressAttributeValueModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Address.AddressAttributes.Values.Fields.Name.Required"));
        }
    }
}