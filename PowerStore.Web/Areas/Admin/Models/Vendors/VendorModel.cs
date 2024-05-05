using PowerStore.Framework.Localization;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using PowerStore.Web.Areas.Admin.Models.Common;
using PowerStore.Web.Areas.Admin.Models.Discounts;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Areas.Admin.Models.Vendors
{
    public partial class VendorModel : BaseEntityModel, ILocalizedModel<VendorLocalizedModel>
    {
        public VendorModel()
        {
            if (PageSize < 1)
            {
                PageSize = 5;
            }
            Locales = new List<VendorLocalizedModel>();
            AssociatedCustomers = new List<AssociatedCustomerInfo>();
            Address = new AddressModel();
            AvailableStores = new List<SelectListItem>();
        }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.Email")]

        public string Email { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.Description")]

        public string Description { get; set; }

        [UIHint("Picture")]
        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.Picture")]
        public string PictureId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.Store")]
        public string StoreId { get; set; }
        public List<SelectListItem> AvailableStores { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.AdminComment")]

        public string AdminComment { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.Active")]
        public bool Active { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.AllowCustomerReviews")]
        public bool AllowCustomerReviews { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.MetaKeywords")]

        public string MetaKeywords { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.MetaDescription")]

        public string MetaDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.MetaTitle")]

        public string MetaTitle { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.SeName")]

        public string SeName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.PageSize")]
        public int PageSize { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.AllowCustomersToSelectPageSize")]
        public bool AllowCustomersToSelectPageSize { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.PageSizeOptions")]
        public string PageSizeOptions { get; set; }

        public IList<VendorLocalizedModel> Locales { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.AssociatedCustomerEmails")]
        public IList<AssociatedCustomerInfo> AssociatedCustomers { get; set; }

        public AddressModel Address { get; set; }

        //vendor notes
        [PowerStoreResourceDisplayName("Admin.Vendors.VendorNotes.Fields.Note")]

        public string AddVendorNoteMessage { get; set; }

        public List<DiscountModel> AvailableDiscounts { get; set; }
        public string[] SelectedDiscountIds { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.Commission")]
        public decimal? Commission { get; set; }

        #region Nested classes

        public class AssociatedCustomerInfo : BaseEntityModel
        {
            public string Email { get; set; }
        }


        public partial class VendorNote : BaseEntityModel
        {
            public string VendorId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Vendors.VendorNotes.Fields.Note")]
            public string Note { get; set; }
            [PowerStoreResourceDisplayName("Admin.Vendors.VendorNotes.Fields.CreatedOn")]
            public DateTime CreatedOn { get; set; }
        }
        #endregion

    }

    public partial class VendorLocalizedModel : ILocalizedModelLocal, ISlugModelLocal
    {
        public string LanguageId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.Name")]

        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.Description")]

        public string Description { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.MetaKeywords")]

        public string MetaKeywords { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.MetaDescription")]

        public string MetaDescription { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.MetaTitle")]

        public string MetaTitle { get; set; }

        [PowerStoreResourceDisplayName("Admin.Vendors.Fields.SeName")]

        public string SeName { get; set; }
    }
}