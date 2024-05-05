using FluentValidation;
using PowerStore.Api.DTOs.Catalog;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Services.Media;
using System.Collections.Generic;

namespace PowerStore.Api.Validators.Catalog
{
    public class ProductPictureValidator : BasePowerStoreValidator<ProductPictureDto>
    {
        public ProductPictureValidator(IEnumerable<IValidatorConsumer<ProductPictureDto>> validators,
            ILocalizationService localizationService, IPictureService pictureService)
            : base(validators)
        {
            RuleFor(x => x).MustAsync(async (x, y, context) =>
            {
                var picture = await pictureService.GetPictureById(x.PictureId);
                if (picture == null)
                    return false;
                return true;
            }).WithMessage(localizationService.GetResource("Api.Catalog.ProductPicture.Fields.PictureId.NotExists"));
        }
    }
}
