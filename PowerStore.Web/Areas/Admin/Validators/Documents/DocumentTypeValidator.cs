using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Documents;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Documents
{
    public class DocumentTypeValidator : BasePowerStoreValidator<DocumentTypeModel>
    {
        public DocumentTypeValidator(
            IEnumerable<IValidatorConsumer<DocumentTypeModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Admin.Documents.Type.Fields.Name.Required"));
        }
    }
}
