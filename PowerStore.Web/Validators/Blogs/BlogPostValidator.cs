using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Models.Blogs;
using System.Collections.Generic;

namespace PowerStore.Web.Validators.Blogs
{
    public class BlogPostValidator : BasePowerStoreValidator<BlogPostModel>
    {
        public BlogPostValidator(
            IEnumerable<IValidatorConsumer<BlogPostModel>> validators,
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.AddNewComment.CommentText).NotEmpty().WithMessage(localizationService.GetResource("Blog.Comments.CommentText.Required")).When(x => x.AddNewComment != null);
        }}
}