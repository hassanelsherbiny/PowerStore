using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Vendors;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Vendors
{
    public class VendorReviewValidator : BasePowerStoreValidator<VendorReviewModel>
    {
        public VendorReviewValidator(
            IEnumerable<IValidatorConsumer<VendorReviewModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage(localizationService.GetResource("Admin.VendorReviews.Fields.Title.Required"));
            RuleFor(x => x.ReviewText).NotEmpty().WithMessage(localizationService.GetResource("Admin.VendorReviews.Fields.ReviewText.Required"));
        }
    }
}
