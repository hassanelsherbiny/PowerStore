using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Knowledgebase;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Knowledgebase;
using System.Collections.Generic;
using System.Linq;

namespace PowerStore.Web.Areas.Admin.Validators.Knowledgebase
{
    public class KnowledgebaseCategoryModelValidator : BasePowerStoreValidator<KnowledgebaseCategoryModel>
    {
        public KnowledgebaseCategoryModelValidator(
            IEnumerable<IValidatorConsumer<KnowledgebaseCategoryModel>> validators,
            ILocalizationService localizationService, IKnowledgebaseService knowledgebaseService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.Knowledgebase.KnowledgebaseCategory.Fields.Name.Required"));
            RuleFor(x => x.ParentCategoryId).MustAsync(async (x, y, context) =>
            {
                var category = await knowledgebaseService.GetKnowledgebaseCategory(x.ParentCategoryId);
                if (category != null || string.IsNullOrEmpty(x.ParentCategoryId))
                {
                    return true;
                }
                else
                {
                    var categories = await knowledgebaseService.GetKnowledgebaseCategories();
                    if (!categories.Any())
                    {
                        return true;
                    }
                }

                return false;
            }).WithMessage(localizationService.GetResource("Admin.ContentManagement.Knowledgebase.KnowledgebaseCategory.Fields.ParentCategoryId.MustExist"));
        }
    }
}
