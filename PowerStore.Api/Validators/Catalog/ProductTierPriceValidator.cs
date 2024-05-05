using FluentValidation;
using PowerStore.Api.DTOs.Catalog;
using PowerStore.Core.Validators;
using PowerStore.Services.Customers;
using PowerStore.Services.Localization;
using PowerStore.Services.Stores;
using System.Collections.Generic;

namespace PowerStore.Api.Validators.Catalog
{
    public class ProductTierPriceValidator : BasePowerStoreValidator<ProductTierPriceDto>
    {
        public ProductTierPriceValidator(
            IEnumerable<IValidatorConsumer<ProductTierPriceDto>> validators,
            ILocalizationService localizationService, IStoreService storeService, ICustomerService customerService)
            : base(validators)
        {
            RuleFor(x => x.Quantity).GreaterThan(0).WithMessage(localizationService.GetResource("Api.Catalog.ProductTierPrice.Fields.Quantity.GreaterThan0"));
            RuleFor(x => x.Price).GreaterThan(0).WithMessage(localizationService.GetResource("Api.Catalog.ProductTierPrice.Fields.Price.GreaterThan0"));

            RuleFor(x => x).MustAsync(async (x, y, context) =>
            {
                if (!string.IsNullOrEmpty(x.StoreId))
                {
                    var store = await storeService.GetStoreById(x.StoreId);
                    if (store == null)
                        return false;
                }
                return true;
            }).WithMessage(localizationService.GetResource("Api.Catalog.ProductTierPrice.Fields.StoreId.NotExists"));
            RuleFor(x => x).MustAsync(async (x, y, context) =>
            {
                if (!string.IsNullOrEmpty(x.CustomerRoleId))
                {
                    var role = await customerService.GetCustomerRoleById(x.CustomerRoleId);
                    if (role == null)
                        return false;
                }
                return true;
            }).WithMessage(localizationService.GetResource("Api.Catalog.ProductTierPrice.Fields.CustomerRoleId.NotExists"));
        }
    }
}
