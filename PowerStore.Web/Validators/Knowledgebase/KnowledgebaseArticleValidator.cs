using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Models.Knowledgebase;
using System.Collections.Generic;

namespace PowerStore.Web.Validators.Knowledgebase
{
    public class KnowledgebaseArticleValidator : BasePowerStoreValidator<KnowledgebaseArticleModel>
    {
        public KnowledgebaseArticleValidator(
            IEnumerable<IValidatorConsumer<KnowledgebaseArticleModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.AddNewComment.CommentText).NotEmpty().WithMessage(localizationService.GetResource("PowerStore.knowledgebase.addarticlecomment.result")).When(x => x.AddNewComment != null);
        }
    }
}