using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Plugin.Widgets.Slider.Domain;
using PowerStore.Plugin.Widgets.Slider.Models;
using PowerStore.Services.Localization;
using System.Collections.Generic;

namespace PowerStore.Plugin.Widgets.Slider.Validators
{
    public class SliderValidator : BasePowerStoreValidator<SlideModel>
    {
        public SliderValidator(IEnumerable<IValidatorConsumer<SlideModel>> validators, 
            ILocalizationService localizationService) : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Plugins.Widgets.Slider.Name.Required"));
            RuleFor(x => x.SliderTypeId == (int)SliderType.Category && string.IsNullOrEmpty(x.CategoryId)).Equal(false).WithMessage(localizationService.GetResource("Plugins.Widgets.Slider.Category.Required"));
            RuleFor(x => x.SliderTypeId == (int)SliderType.Manufacturer && string.IsNullOrEmpty(x.ManufacturerId)).Equal(false).WithMessage(localizationService.GetResource("Plugins.Widgets.Slider.Manufacturer.Required"));
        }
    }
}