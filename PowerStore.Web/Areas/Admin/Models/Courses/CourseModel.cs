using PowerStore.Framework.Localization;
using PowerStore.Framework.Mapping;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PowerStore.Framework.Mvc.Models;

namespace PowerStore.Web.Areas.Admin.Models.Courses
{
    public partial class CourseModel : BaseEntityModel, ILocalizedModel<CourseLocalizedModel>, IAclMappingModel, IStoreMappingModel
    {
        public CourseModel()
        {
            Locales = new List<CourseLocalizedModel>();
            AvailableLevels = new List<SelectListItem>();
        }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.ShortDescription")]
        public string ShortDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.Description")]
        public string Description { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.Published")]
        public bool Published { get; set; }

        [UIHint("Picture")]
        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.PictureId")]
        public string PictureId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.LevelId")]
        public string LevelId { get; set; }
        public IList<SelectListItem> AvailableLevels { get; set; }

        //ACL
        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.SubjectToAcl")]
        public bool SubjectToAcl { get; set; }
        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.AclCustomerRoles")]
        public List<CustomerRoleModel> AvailableCustomerRoles { get; set; }
        public string[] SelectedCustomerRoleIds { get; set; }

        //Store mapping
        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }
        public string[] SelectedStoreIds { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.MetaKeywords")]
        public string MetaKeywords { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.MetaDescription")]

        public string MetaDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.MetaTitle")]

        public string MetaTitle { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.SeName")]

        public string SeName { get; set; }

        public IList<CourseLocalizedModel> Locales { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.ProductId")]
        public string ProductId { get; set; }
        public string ProductName { get; set; }

        #region Nested classes

        public partial class AssociateProductToCourseModel : BaseModel
        {
            public AssociateProductToCourseModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableStores = new List<SelectListItem>();
                AvailableVendors = new List<SelectListItem>();
                AvailableProductTypes = new List<SelectListItem>();
            }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductName")]

            public string SearchProductName { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchCategory")]
            public string SearchCategoryId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchManufacturer")]
            public string SearchManufacturerId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchStore")]
            public string SearchStoreId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchVendor")]
            public string SearchVendorId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductType")]
            public int SearchProductTypeId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableStores { get; set; }
            public IList<SelectListItem> AvailableVendors { get; set; }
            public IList<SelectListItem> AvailableProductTypes { get; set; }

            //vendor
            public bool IsLoggedInAsVendor { get; set; }


            public string AssociatedToProductId { get; set; }
        }
        #endregion
    }

    public partial class CourseLocalizedModel : ILocalizedModelLocal, ISlugModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.ShortDescription")]

        public string ShortDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.Description")]

        public string Description { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.MetaKeywords")]

        public string MetaKeywords { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.MetaDescription")]

        public string MetaDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.MetaTitle")]

        public string MetaTitle { get; set; }

        [PowerStoreResourceDisplayName("Admin.Courses.Course.Fields.SeName")]

        public string SeName { get; set; }

    }
}
