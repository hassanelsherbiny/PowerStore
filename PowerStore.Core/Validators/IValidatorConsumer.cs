namespace PowerStore.Core.Validators
{
    public interface IValidatorConsumer<T> where T : class
    {
        void AddRules(BasePowerStoreValidator<T> validator);
    }
}
