using FluentValidation;
using PowerStore.Api.DTOs.Common;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using System.Collections.Generic;

namespace PowerStore.Api.Validators.Common
{
    public class PictureValidator : BasePowerStoreValidator<PictureDto>
    {
        public PictureValidator(
            IEnumerable<IValidatorConsumer<PictureDto>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.PictureBinary).NotEmpty().WithMessage(localizationService.GetResource("Api.Common.Picture.Fields.PictureBinary.Required"));
            RuleFor(x => x.MimeType).NotEmpty().WithMessage(localizationService.GetResource("Api.Common.Picture.Fields.MimeType.Required"));
            RuleFor(x => x.Id).Empty().WithMessage(localizationService.GetResource("Api.Common.Picture.Fields.Id.NotRequired"));
        }
    }
}
