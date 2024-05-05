using PowerStore.Core.Mapper;
using PowerStore.Domain.Localization;
using PowerStore.Web.Areas.Admin.Models.Localization;

namespace PowerStore.Web.Areas.Admin.Extensions
{
    public static class LanguageMappingExtensions
    {
        public static LanguageModel ToModel(this Language entity)
        {
            return entity.MapTo<Language, LanguageModel>();
        }

        public static Language ToEntity(this LanguageModel model)
        {
            return model.MapTo<LanguageModel, Language>();
        }

        public static Language ToEntity(this LanguageModel model, Language destination)
        {
            return model.MapTo(destination);
        }
    }
}