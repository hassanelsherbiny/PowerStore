using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Models.Catalog;
using System.Collections.Generic;

namespace PowerStore.Web.Validators.Catalog
{
    public class ProductReviewsValidator : BasePowerStoreValidator<AddProductReviewModel>
    {
        public ProductReviewsValidator(
            IEnumerable<IValidatorConsumer<AddProductReviewModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage(localizationService.GetResource("Reviews.Fields.Title.Required"));
            RuleFor(x => x.Title).Length(1, 200).WithMessage(string.Format(localizationService.GetResource("Reviews.Fields.Title.MaxLengthValidation"), 200));
            RuleFor(x => x.ReviewText).NotEmpty().WithMessage(localizationService.GetResource("Reviews.Fields.ReviewText.Required"));
        }
    }
}