using PowerStore.Domain.Catalog;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PowerStore.Framework.Mvc.Models;
using PowerStore.Domain.Common;

namespace PowerStore.Web.Areas.Admin.Models.Customers
{
    public partial class CustomerModel : BaseEntityModel
    {
        public CustomerModel()
        {
            AvailableTimeZones = new List<SelectListItem>();
            SendEmail = new SendEmailModel() { SendImmediately = true };
            AvailableCustomerRoles = new List<CustomerRoleModel>();
            AssociatedExternalAuthRecords = new List<AssociatedExternalAuthModel>();
            AvailableCountries = new List<SelectListItem>();
            AvailableStates = new List<SelectListItem>();
            AvailableVendors = new List<SelectListItem>();
            AvailableStores = new List<SelectListItem>();
            AvailableSalesEmployees = new List<SelectListItem>();
            CustomerAttributes = new List<CustomerAttributeModel>();
            AvailableNewsletterSubscriptionStores = new List<StoreModel>();
            RewardPointsAvailableStores = new List<SelectListItem>();
            Attributes = new List<CustomAttribute>();
        }

        public bool AllowUsersToChangeUsernames { get; set; }
        public bool UsernamesEnabled { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.Username")]
        public string Username { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.Email")]
        public string Email { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.Owner")]
        public string Owner { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.CustomerTags")]
        public string CustomerTags { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.Vendor")]
        public string VendorId { get; set; }

        public IList<SelectListItem> AvailableVendors { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.SeId")]
        public string SeId { get; set; }
        public IList<SelectListItem> AvailableSalesEmployees { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.StaffStore")]
        public string StaffStoreId { get; set; }
        public IList<SelectListItem> AvailableStores { get; set; }

        //form fields & properties
        public bool GenderEnabled { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.Gender")]
        public string Gender { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.FirstName")]
        public string FirstName { get; set; }
        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.LastName")]

        public string LastName { get; set; }
        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.FullName")]
        public string FullName { get; set; }

        public bool DateOfBirthEnabled { get; set; }
        [UIHint("DateNullable")]
        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.DateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        public bool CompanyEnabled { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.Company")]
        public string Company { get; set; }

        public bool StreetAddressEnabled { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.StreetAddress")]
        public string StreetAddress { get; set; }

        public bool StreetAddress2Enabled { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.StreetAddress2")]
        public string StreetAddress2 { get; set; }

        public bool ZipPostalCodeEnabled { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.ZipPostalCode")]
        public string ZipPostalCode { get; set; }

        public bool CityEnabled { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.City")]
        public string City { get; set; }

        public bool CountryEnabled { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.Country")]
        public string CountryId { get; set; }
        public IList<SelectListItem> AvailableCountries { get; set; }

        public bool StateProvinceEnabled { get; set; }
        
        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.StateProvince")]
        public string StateProvinceId { get; set; }
        public IList<SelectListItem> AvailableStates { get; set; }

        public bool PhoneEnabled { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.Phone")]
        public string Phone { get; set; }

        public bool FaxEnabled { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.Fax")]
        public string Fax { get; set; }

        public List<CustomerAttributeModel> CustomerAttributes { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.AdminComment")]
        public string AdminComment { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.IsTaxExempt")]
        public bool IsTaxExempt { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.FreeShipping")]
        public bool FreeShipping { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.Active")]
        public bool Active { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.Affiliate")]
        public string AffiliateId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.Affiliate")]
        public string AffiliateName { get; set; }
        
        public IList<CustomAttribute> Attributes { get; set; }

        //time zone
        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.TimeZoneId")]
        public string TimeZoneId { get; set; }

        public bool AllowCustomersToSetTimeZone { get; set; }

        public IList<SelectListItem> AvailableTimeZones { get; set; }

        //EU VAT
        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.VatNumber")]

        public string VatNumber { get; set; }

        public string VatNumberStatusNote { get; set; }

        public bool DisplayVatNumber { get; set; }

        //registration date
        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }
        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.LastActivityDate")]
        public DateTime LastActivityDate { get; set; }
        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.LastPurchaseDate")]
        public DateTime? LastPurchaseDate { get; set; }

        //IP adderss
        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.IPAddress")]
        public string LastIpAddress { get; set; }

        //Url referrer
        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.URLReferrer")]
        public string UrlReferrer { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.LastVisitedPage")]
        public string LastVisitedPage { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.LastUrlReferrer")]
        public string LastUrlReferrer { get; set; }

        //customer roles
        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.CustomerRoles")]
        public string CustomerRoleNames { get; set; }
        public List<CustomerRoleModel> AvailableCustomerRoles { get; set; }
        public string[] SelectedCustomerRoleIds { get; set; }

        //newsletter subscriptions (per store)
        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.Newsletter")]
        public List<StoreModel> AvailableNewsletterSubscriptionStores { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.Fields.Newsletter")]
        public string[] SelectedNewsletterSubscriptionStoreIds { get; set; }

        //reward points history
        public bool DisplayRewardPointsHistory { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.AddRewardPointsValue")]
        public int AddRewardPointsValue { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.AddRewardPointsMessage")]
        public string AddRewardPointsMessage { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.AddRewardPointsStore")]
        public string AddRewardPointsStoreId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.AddRewardPointsStore")]
        public IList<SelectListItem> RewardPointsAvailableStores { get; set; }

        //send email model
        public SendEmailModel SendEmail { get; set; }

        //send the welcome message
        public bool AllowSendingOfWelcomeMessage { get; set; }
        //re-send the activation message
        public bool AllowReSendingOfActivationMessage { get; set; }
        public bool ShowMessageContactForm { get; set; }

        //external auth
        [PowerStoreResourceDisplayName("Admin.Customers.Customers.AssociatedExternalAuth")]
        public IList<AssociatedExternalAuthModel> AssociatedExternalAuthRecords { get; set; }
        //customer notes
        [PowerStoreResourceDisplayName("Admin.Customers.CustomerNotes.Fields.DisplayToCustomer")]
        public bool AddCustomerNoteDisplayToCustomer { get; set; }
        [PowerStoreResourceDisplayName("Admin.Customers.CustomerNotes.Fields.Title")]
        public string AddCustomerTitle { get; set; }
        [PowerStoreResourceDisplayName("Admin.Customers.CustomerNotes.Fields.Note")]
        public string AddCustomerNoteMessage { get; set; }
        public bool AddCustomerNoteHasDownload { get; set; }
        [PowerStoreResourceDisplayName("Admin.Customers.CustomerNotes.Fields.Download")]
        [UIHint("Download")]
        public string AddCustomerNoteDownloadId { get; set; }

        #region Nested classes

        public partial class AssociatedExternalAuthModel : BaseEntityModel
        {
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.AssociatedExternalAuth.Fields.Email")]
            public string Email { get; set; }

            [PowerStoreResourceDisplayName("Admin.Customers.Customers.AssociatedExternalAuth.Fields.ExternalIdentifier")]
            public string ExternalIdentifier { get; set; }

            [PowerStoreResourceDisplayName("Admin.Customers.Customers.AssociatedExternalAuth.Fields.AuthMethodName")]
            public string AuthMethodName { get; set; }
        }

        public partial class RewardPointsHistoryModel : BaseEntityModel
        {
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.Store")]
            public string StoreName { get; set; }

            [PowerStoreResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.Points")]
            public int Points { get; set; }

            [PowerStoreResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.PointsBalance")]
            public int PointsBalance { get; set; }

            [PowerStoreResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.Message")]
            public string Message { get; set; }

            [PowerStoreResourceDisplayName("Admin.Customers.Customers.RewardPoints.Fields.Date")]
            public DateTime CreatedOn { get; set; }
        }

        public partial class SendEmailModel : BaseModel
        {
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.SendEmail.Subject")]
            public string Subject { get; set; }

            [PowerStoreResourceDisplayName("Admin.Customers.Customers.SendEmail.Body")]
            public string Body { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.SendEmail.SendImmediately")]
            public bool SendImmediately { get; set; }

            [PowerStoreResourceDisplayName("Admin.Customers.Customers.SendEmail.DontSendBeforeDate")]
            [UIHint("DateTimeNullable")]
            public DateTime? DontSendBeforeDate { get; set; }
        }

        public partial class OrderModel : BaseEntityModel
        {
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.Orders.ID")]
            public override string Id { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.Orders.ID")]
            public int OrderNumber { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.Orders.Code")]
            public string OrderCode { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.Orders.OrderStatus")]
            public string OrderStatus { get; set; }
            public int OrderStatusId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.Orders.PaymentStatus")]
            public string PaymentStatus { get; set; }
            public int PaymentStatusId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.Orders.ShippingStatus")]
            public string ShippingStatus { get; set; }
            public int ShippingStatusId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.Orders.OrderTotal")]
            public string OrderTotal { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.Orders.Store")]
            public string StoreName { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.Orders.CreatedOn")]
            public DateTime CreatedOn { get; set; }
        }

        public partial class ActivityLogModel : BaseEntityModel
        {
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.ActivityLog.ActivityLogType")]
            public string ActivityLogTypeName { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.ActivityLog.Comment")]
            public string Comment { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.ActivityLog.CreatedOn")]
            public DateTime CreatedOn { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.ActivityLog.IpAddress")]
            public string IpAddress { get; set; }
        }
        public partial class ProductModel : BaseEntityModel
        {
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.PersonalizedProduct.ProductName")]
            public string ProductName { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.PersonalizedProduct.DisplayOrder")]
            public int DisplayOrder { get; set; }
            public string ProductId { get; set; }
        }
        public partial class ProductPriceModel : BaseEntityModel
        {
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.ProductPrice.ProductName")]
            public string ProductName { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.ProductPrice.Price")]
            public decimal Price { get; set; }
            public string ProductId { get; set; }
        }
        public partial class AddProductModel : BaseModel
        {
            public AddProductModel()
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

            public string CustomerId { get; set; }

            public string[] SelectedProductIds { get; set; }
        }
        public partial class BackInStockSubscriptionModel : BaseEntityModel
        {
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.BackInStockSubscriptions.Store")]
            public string StoreName { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.BackInStockSubscriptions.Product")]
            public string ProductId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.BackInStockSubscriptions.Product")]
            public string ProductName { get; set; }
            public string AttributeDescription { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.Customers.BackInStockSubscriptions.CreatedOn")]
            public DateTime CreatedOn { get; set; }
        }

        public partial class CustomerAttributeModel : BaseEntityModel
        {
            public CustomerAttributeModel()
            {
                Values = new List<CustomerAttributeValueModel>();
            }

            public string Name { get; set; }

            public bool IsRequired { get; set; }

            /// <summary>
            /// Default value for textboxes
            /// </summary>
            public string DefaultValue { get; set; }

            public AttributeControlType AttributeControlType { get; set; }

            public IList<CustomerAttributeValueModel> Values { get; set; }

        }

        public partial class CustomerAttributeValueModel : BaseEntityModel
        {
            public string Name { get; set; }

            public bool IsPreSelected { get; set; }
        }

        public partial class CustomerNote : BaseEntityModel
        {
            public string CustomerId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.CustomerNotes.Fields.DisplayToCustomer")]
            public bool DisplayToCustomer { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.CustomerNotes.Fields.Title")]
            public string Title { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.CustomerNotes.Fields.Note")]
            public string Note { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.CustomerNotes.Fields.Download")]
            public string DownloadId { get; set; }
            public Guid DownloadGuid { get; set; }
            [PowerStoreResourceDisplayName("Admin.Customers.CustomerNotes.Fields.CreatedOn")]
            public DateTime CreatedOn { get; set; }
        }

        #endregion
    }
}