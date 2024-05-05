using PowerStore.Framework.Localization;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Polls
{
    public partial class PollAnswerModel : BaseEntityModel, ILocalizedModel<PollAnswerLocalizedModel>
    {
        public PollAnswerModel()
        {
            Locales = new List<PollAnswerLocalizedModel>();
        }

        public string PollId { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Polls.Answers.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Polls.Answers.Fields.NumberOfVotes")]
        public int NumberOfVotes { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Polls.Answers.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        public IList<PollAnswerLocalizedModel> Locales { get; set; }


    }

    public partial class PollAnswerLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Polls.Answers.Fields.Name")]

        public string Name { get; set; }
    }


}