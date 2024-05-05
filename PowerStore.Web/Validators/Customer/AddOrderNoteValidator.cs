using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Models.Orders;
using System.Collections.Generic;

namespace PowerStore.Web.Validators.Customer
{
    public class AddOrderNoteValidator : BasePowerStoreValidator<AddOrderNoteModel>
    {
        public AddOrderNoteValidator(
            IEnumerable<IValidatorConsumer<AddOrderNoteModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Note).NotEmpty().WithMessage(localizationService.GetResource("OrderNote.Fields.Title.Required"));
        }
    }
}
