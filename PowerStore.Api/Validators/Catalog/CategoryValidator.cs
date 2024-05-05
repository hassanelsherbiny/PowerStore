using FluentValidation;
using PowerStore.Api.DTOs.Catalog;
using PowerStore.Core.Validators;
using PowerStore.Services.Catalog;
using PowerStore.Services.Localization;
using PowerStore.Services.Media;
using System.Collections.Generic;

namespace PowerStore.Api.Validators.Catalog
{
    public class CategoryValidator : BasePowerStoreValidator<CategoryDto>
    {
        public CategoryValidator(IEnumerable<IValidatorConsumer<CategoryDto>> validators,
            ILocalizationService localizationService, IPictureService pictureService, ICategoryService categoryService, ICategoryTemplateService
            categoryTemplateService) : base(validators)
        {

            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Api.Catalog.Category.Fields.Name.Required"));
            RuleFor(x => x).MustAsync(async (x, y, context) =>
            {
                if (!string.IsNullOrEmpty(x.PictureId))
                {
                    var picture = await pictureService.GetPictureById(x.PictureId);
                    if (picture == null)
                        return false;
                }
                return true;
            }).WithMessage(localizationService.GetResource("Api.Catalog.Category.Fields.PictureId.NotExists"));

            RuleFor(x => x).MustAsync(async (x, y, context) =>
            {
                if (!string.IsNullOrEmpty(x.ParentCategoryId))
                {
                    var category = await categoryService.GetCategoryById(x.ParentCategoryId);
                    if (category == null)
                        return false;
                }
                return true;
            }).WithMessage(localizationService.GetResource("Api.Catalog.Category.Fields.ParentCategoryId.NotExists"));

            RuleFor(x => x).MustAsync(async (x, y, context) =>
            {
                if (!string.IsNullOrEmpty(x.CategoryTemplateId))
                {
                    var template = await categoryTemplateService.GetCategoryTemplateById(x.CategoryTemplateId);
                    if (template == null)
                        return false;
                }
                return true;
            }).WithMessage(localizationService.GetResource("Api.Catalog.Category.Fields.CategoryTemplateId.NotExists"));

            RuleFor(x => x).MustAsync(async (x, y, context) =>
            {
                if (!string.IsNullOrEmpty(x.Id))
                {
                    var category = await categoryService.GetCategoryById(x.Id);
                    if (category == null)
                        return false;
                }
                return true;
            }).WithMessage(localizationService.GetResource("Api.Catalog.Category.Fields.Id.NotExists"));
        }
    }
}
