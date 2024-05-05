#! "netcoreapp3.1"
#r "PowerStore.Core"
#r "PowerStore.Framework"
#r "PowerStore.Services"
#r "PowerStore.Web"


using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Events;
using PowerStore.Web.Models.Common;
using System.Threading.Tasks;
using System;

/* Sample code to validate ZIP Code field in the Address */
public class ZipCodeValidation : IValidatorConsumer<AddressModel>
{
    public void AddRules(BasePowerStoreValidator<AddressModel> validator)
    {
        validator.RuleFor(x => x.ZipPostalCode).Matches(@"^[0-9]{2}\-[0-9]{3}$")
            .WithMessage("Provided zip code is invalid");
    }
}
