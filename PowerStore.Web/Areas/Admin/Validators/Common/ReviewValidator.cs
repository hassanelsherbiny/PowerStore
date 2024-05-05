using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Common;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Common
{
    public class ReviewValidator : BasePowerStoreValidator<ReviewModel>
    {
        public ReviewValidator(
            IEnumerable<IValidatorConsumer<ReviewModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Admin.Review.Fields.Title.Required"));
            RuleFor(x => x.ReviewText)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Admin.Review.Fields.ReviewText.Required"));
        }
    }
}