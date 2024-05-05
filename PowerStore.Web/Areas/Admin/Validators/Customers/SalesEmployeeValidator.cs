using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Customers;
using PowerStore.Web.Areas.Admin.Validators.Common;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Directory
{
    public class SalesEmployeeValidator : BasePowerStoreValidator<SalesEmployeeModel>
    {
        public SalesEmployeeValidator(
            IEnumerable<IValidatorConsumer<SalesEmployeeModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.Customers.SalesEmployee.Fields.Name.Required"));
            RuleFor(x => x.Commission)
                .Must(CommonValid.IsCommissionValid)
                .WithMessage(localizationService.GetResource("Admin.Customers.SalesEmployee.Fields.Commission.IsCommissionValid"));
        }
    }
}