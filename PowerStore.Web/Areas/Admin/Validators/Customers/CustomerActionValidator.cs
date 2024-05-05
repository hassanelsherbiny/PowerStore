using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Customers;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Customers
{
    public class CustomerActionValidator : BasePowerStoreValidator<CustomerActionModel>
    {
        public CustomerActionValidator(
            IEnumerable<IValidatorConsumer<CustomerActionModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Customers.CustomerAction.Fields.Name.Required"));            
        }
    }
}