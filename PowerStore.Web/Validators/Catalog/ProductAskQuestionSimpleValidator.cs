using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Models.Catalog;
using System.Collections.Generic;

namespace PowerStore.Web.Validators.Catalog
{
    public class ProductAskQuestionSimpleValidator : BasePowerStoreValidator<ProductAskQuestionSimpleModel>
    {
        public ProductAskQuestionSimpleValidator(
            IEnumerable<IValidatorConsumer<ProductAskQuestionSimpleModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.AskQuestionEmail).NotEmpty().WithMessage(localizationService.GetResource("Products.AskQuestion.Email.Required"));
            RuleFor(x => x.AskQuestionEmail).EmailAddress().WithMessage(localizationService.GetResource("Common.WrongEmail"));
            RuleFor(x => x.AskQuestionMessage).NotEmpty().WithMessage(localizationService.GetResource("Products.AskQuestion.Message.Required"));
            RuleFor(x => x.AskQuestionFullName).NotEmpty().WithMessage(localizationService.GetResource("Products.AskQuestion.FullName.Required"));
        }
    }
}