using PowerStore.Framework.Localization;
using PowerStore.Framework.Mapping;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PowerStore.Framework.Mvc.Models;

namespace PowerStore.Web.Areas.Admin.Models.News
{
    public partial class NewsItemModel : BaseEntityModel, ILocalizedModel<NewsLocalizedModel>, IAclMappingModel, IStoreMappingModel
    {
        public NewsItemModel()
        {
            AvailableStores = new List<StoreModel>();
            AvailableCustomerRoles = new List<CustomerRoleModel>();
            Locales = new List<NewsLocalizedModel>();
        }

        //Store mapping
        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }
        public string[] SelectedStoreIds { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.Title")]
        public string Title { get; set; }

        [UIHint("Picture")]
        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.Picture")]
        public string PictureId { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.Short")]
        public string Short { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.Full")]
        public string Full { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.AllowComments")]
        public bool AllowComments { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.StartDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? StartDate { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.EndDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? EndDate { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.MetaKeywords")]
        public string MetaKeywords { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.MetaDescription")]
        public string MetaDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.MetaTitle")]
        public string MetaTitle { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.SeName")]
        public string SeName { get; set; }

        public IList<NewsLocalizedModel> Locales { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.Published")]
        public bool Published { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.Comments")]
        public int Comments { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        //ACL
        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.SubjectToAcl")]
        public bool SubjectToAcl { get; set; }
        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.AclCustomerRoles")]
        public List<CustomerRoleModel> AvailableCustomerRoles { get; set; }
        public string[] SelectedCustomerRoleIds { get; set; }

    }

    public partial class NewsLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.Title")]

        public string Title { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.Short")]

        public string Short { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.Full")]

        public string Full { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.MetaKeywords")]

        public string MetaKeywords { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.MetaDescription")]

        public string MetaDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.MetaTitle")]

        public string MetaTitle { get; set; }

        [PowerStoreResourceDisplayName("Admin.ContentManagement.News.NewsItems.Fields.SeName")]

        public string SeName { get; set; }

    }

}