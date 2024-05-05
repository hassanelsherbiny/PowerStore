using FluentValidation;
using PowerStore.Api.DTOs.Customers;
using PowerStore.Domain.Customers;
using PowerStore.Core.Validators;
using PowerStore.Services.Catalog;
using PowerStore.Services.Customers;
using PowerStore.Services.Localization;
using System;
using System.Collections.Generic;

namespace PowerStore.Api.Validators.Customers
{
    public class CustomerRoleValidator : BasePowerStoreValidator<CustomerRoleDto>
    {
        public CustomerRoleValidator(
            IEnumerable<IValidatorConsumer<CustomerRoleDto>> validators,
            ILocalizationService localizationService, IProductService productService, ICustomerService customerService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Api.Customers.CustomerRole.Fields.Name.Required"));
            
            RuleFor(x => x).MustAsync(async (x, context) =>
            {
                if (!string.IsNullOrEmpty(x.Id))
                {
                    var role = await customerService.GetCustomerRoleById(x.Id);
                    if (role == null)
                        return false;
                }
                return true;
            }).WithMessage(localizationService.GetResource("Api.Customers.CustomerRole.Fields.Id.NotExists"));
            RuleFor(x => x).MustAsync(async (x, context) =>
            {
                if (!string.IsNullOrEmpty(x.Id))
                {
                    var customerRole = await customerService.GetCustomerRoleById(x.Id);
                    if (customerRole.IsSystemRole && !x.Active)
                    {
                        return false;
                    }
                }
                return true;
            }).WithMessage(localizationService.GetResource("Api.Customers.CustomerRoles.Fields.Active.CantEditSystem"));
            RuleFor(x => x).MustAsync(async (x, context) =>
            {
                if (!string.IsNullOrEmpty(x.Id))
                {
                    var customerRole = await customerService.GetCustomerRoleById(x.Id);
                    if (customerRole.IsSystemRole && !customerRole.SystemName.Equals(x.SystemName, StringComparison.OrdinalIgnoreCase))
                    {
                        return false;
                    }
                }
                return true;
            }).WithMessage(localizationService.GetResource("Api.Customers.CustomerRoles.Fields.SystemName.CantEditSystem"));            
        }
    }
}
