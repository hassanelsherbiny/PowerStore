using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Documents;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Documents
{
    public class DocumentValidator : BasePowerStoreValidator<DocumentModel>
    {
        public DocumentValidator(
            IEnumerable<IValidatorConsumer<DocumentModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Admin.Documents.Document.Fields.Name.Required"));

            RuleFor(x => x.Number)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Admin.Documents.Document.Fields.Number.Required"));

        }
    }
}
