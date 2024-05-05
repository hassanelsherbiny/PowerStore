using FluentValidation;
using PowerStore.Core.Validators;
using PowerStore.Services.Localization;
using PowerStore.Web.Areas.Admin.Models.Blogs;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Validators.Blogs
{
    public class BlogCategoryValidator : BasePowerStoreValidator<BlogCategoryModel>
    {
        public BlogCategoryValidator(IEnumerable<IValidatorConsumer<BlogCategoryModel>> validators, 
            ILocalizationService localizationService)
            : base(validators)
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage(localizationService.GetResource("Admin.ContentManagement.Blog.BlogCategory.Fields.Name.Required"));
        }
    }
}