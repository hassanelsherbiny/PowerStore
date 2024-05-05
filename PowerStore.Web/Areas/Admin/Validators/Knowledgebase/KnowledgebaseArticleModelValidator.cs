using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Knowledgebase;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Knowledgebase;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Knowledgebase
{
    public class KnowledgebaseArticleModelValidator : BasePowerStoreValidator<KnowledgebaseArticleModel>
    {
        public KnowledgebaseArticleModelValidator(
            IEnumerable<IValidatorConsumer<KnowledgebaseArticleModel>> validators,
            ILocalizationService localizationService, IKnowledgebaseService knowledgebaseService)
            : base(validators)
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.Knowledgebase.KnowledgebaseArticle.Fields.Name.Required"));
            RuleFor(x => x.ParentCategoryId).NotEmpty().WithMessage(localizationService.GetResource("Admin.ContentManagement.Knowledgebase.KnowledgebaseArticle.Fields.ParentCategoryId.Required"));
            RuleFor(x => x.ParentCategoryId).Must(x =>
            {
                var category = knowledgebaseService.GetKnowledgebaseCategory(x);
                if (category != null)
                {
                    return true;
                }

                return false;
            }).WithMessage(localizationService.GetResource("Admin.ContentManagement.Knowledgebase.KnowledgebaseArticle.Fields.ParentCategoryId.MustExist"));
        }
    }
}
