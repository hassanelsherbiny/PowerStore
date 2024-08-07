using FluentValidation;
using System.Collections.Generic;

namespace PowerStore.Core.Validators
{
    public abstract class BasePowerStoreValidator<T> : AbstractValidator<T> where T : class
    {

        protected BasePowerStoreValidator(IEnumerable<IValidatorConsumer<T>> validators)
        {
            PostInitialize(validators);
        }

        protected virtual void PostInitialize(IEnumerable<IValidatorConsumer<T>> validators)
        {
            foreach (var item in validators)
            {
                item.AddRules(this);
            }

        }

    }


}