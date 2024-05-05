using FluentValidation;
using PowerStore.Api.DTOs.Catalog;
using PowerStore.Core.Validators;
using PowerStore.Services.Catalog;
using PowerStore.Services.Localization;
using PowerStore.Services.Media;
using System.Collections.Generic;

namespace PowerStore.Api.Validators.Catalog
{
    public class ManufacturerValidator : BasePowerStoreValidator<ManufacturerDto>
    {
        public ManufacturerValidator(IEnumerable<IValidatorConsumer<ManufacturerDto>> validators,
            ILocalizationService localizationService, IPictureService pictureService, IManufacturerService manufacturerService, IManufacturerTemplateService manufacturerTemplateService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Api.Catalog.Manufacturer.Fields.Name.Required"));
            RuleFor(x => x).MustAsync(async (x, y, context) =>
            {
                if (!string.IsNullOrEmpty(x.PictureId))
                {
                    var picture = await pictureService.GetPictureById(x.PictureId);
                    if (picture == null)
                        return false;
                }
                return true;
            }).WithMessage(localizationService.GetResource("Api.Catalog.Manufacturer.Fields.PictureId.NotExists"));

            RuleFor(x => x).MustAsync(async (x, y, context) =>
            {
                if (!string.IsNullOrEmpty(x.ManufacturerTemplateId))
                {
                    var template = await manufacturerTemplateService.GetManufacturerTemplateById(x.ManufacturerTemplateId);
                    if (template == null)
                        return false;
                }
                return true;
            }).WithMessage(localizationService.GetResource("Api.Catalog.Manufacturer.Fields.ManufacturerTemplateId.NotExists"));

            RuleFor(x => x).MustAsync(async (x, y, context) =>
            {
                if (!string.IsNullOrEmpty(x.Id))
                {
                    var manufacturer = await manufacturerService.GetManufacturerById(x.Id);
                    if (manufacturer == null)
                        return false;
                }
                return true;
            }).WithMessage(localizationService.GetResource("Api.Catalog.Manufacturer.Fields.Id.NotExists"));
        }
    }
}
