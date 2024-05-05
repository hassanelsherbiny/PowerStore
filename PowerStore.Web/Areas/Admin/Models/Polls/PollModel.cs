using PowerStore.Framework.Localization;
using PowerStore.Framework.Mapping;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PowerStore.Framework.Mvc.Models;

namespace PowerStore.Web.Areas.Admin.Models.Polls
{
    public partial class PollModel : BaseEntityModel, ILocalizedModel<PollLocalizedModel>, IAclMappingModel, IStoreMappingModel
    {

        public PollModel()
        {
            AvailableStores = new List<StoreModel>();
            Locales = new List<PollLocalizedModel>();
            AvailableCustomerRoles = new List<CustomerRoleModel>();
        }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Polls.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Polls.Fields.SystemKeyword")]

        public string SystemKeyword { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Polls.Fields.Published")]
        public bool Published { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Polls.Fields.ShowOnHomePage")]
        public bool ShowOnHomePage { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Polls.Fields.AllowGuestsToVote")]
        public bool AllowGuestsToVote { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Polls.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Polls.Fields.StartDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? StartDate { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Polls.Fields.EndDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? EndDate { get; set; }

        //Store mapping
        [PowerStoreResourceDisplayName("Admin.ContentManagement.Polls.Fields.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        [PowerStoreResourceDisplayName("Admin.ContentManagement.Polls.Fields.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }
        public string[] SelectedStoreIds { get; set; }
        public IList<PollLocalizedModel> Locales { get; set; }


        //ACL
        [PowerStoreResourceDisplayName("Admin.ContentManagement.Polls.Fields.SubjectToAcl")]
        public bool SubjectToAcl { get; set; }
        [PowerStoreResourceDisplayName("Admin.ContentManagement.Polls.Fields.AclCustomerRoles")]
        public List<CustomerRoleModel> AvailableCustomerRoles { get; set; }
        public string[] SelectedCustomerRoleIds { get; set; }

    }

    public partial class PollLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.Polls.Fields.Name")]
        public string Name { get; set; }

    }

}