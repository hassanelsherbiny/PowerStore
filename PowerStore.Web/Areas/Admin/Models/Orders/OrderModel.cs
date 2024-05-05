using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using PowerStore.Domain.Catalog;
using PowerStore.Domain.Payments;
using PowerStore.Domain.Tax;
using PowerStore.Web.Areas.Admin.Models.Common;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Areas.Admin.Models.Orders
{
    public partial class OrderModel : BaseEntityModel
    {
        public OrderModel()
        {
            CustomValues = new Dictionary<string, object>();
            TaxRates = new List<TaxRate>();
            GiftCards = new List<GiftCard>();
            Items = new List<OrderItemModel>();
            UsedDiscounts = new List<UsedDiscountModel>();
        }

        public bool IsLoggedInAsVendor { get; set; }

        //identifiers
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.ID")]
        public override string Id { get; set; }

        [PowerStoreResourceDisplayName("Admin.Orders.Fields.ID")]
        public int OrderNumber { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Code")]
        public string Code { get; set; }

        [PowerStoreResourceDisplayName("Admin.Orders.Fields.OrderGuid")]
        public Guid OrderGuid { get; set; }

        //store
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Store")]
        public string StoreName { get; set; }

        //customer info
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Customer")]
        public string CustomerId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Customer")]
        public string CustomerInfo { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.CustomerEmail")]
        public string CustomerEmail { get; set; }
        public string CustomerFullName { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.CustomerIP")]
        public string CustomerIp { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.UrlReferrer")]
        public string UrlReferrer { get; set; }

        [PowerStoreResourceDisplayName("Admin.Orders.Fields.CustomValues")]
        public Dictionary<string, object> CustomValues { get; set; }

        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Affiliate")]
        public string AffiliateId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Affiliate")]
        public string AffiliateName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Orders.Fields.SalesEmployee")]
        public string SalesEmployeeId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.SalesEmployee")]
        public string SalesEmployeeName { get; set; }

        //Used discounts
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.UsedDiscounts")]
        public IList<UsedDiscountModel> UsedDiscounts { get; set; }

        //totals
        public bool AllowCustomersToSelectTaxDisplayType { get; set; }
        public TaxDisplayType TaxDisplayType { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.OrderSubtotalInclTax")]
        public string OrderSubtotalInclTax { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.OrderSubtotalExclTax")]
        public string OrderSubtotalExclTax { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.OrderSubTotalDiscountInclTax")]
        public string OrderSubTotalDiscountInclTax { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.OrderSubTotalDiscountExclTax")]
        public string OrderSubTotalDiscountExclTax { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.OrderShippingInclTax")]
        public string OrderShippingInclTax { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.OrderShippingExclTax")]
        public string OrderShippingExclTax { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.PaymentMethodAdditionalFeeInclTax")]
        public string PaymentMethodAdditionalFeeInclTax { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.PaymentMethodAdditionalFeeExclTax")]
        public string PaymentMethodAdditionalFeeExclTax { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Tax")]
        public string Tax { get; set; }
        public IList<TaxRate> TaxRates { get; set; }
        public bool DisplayTax { get; set; }
        public bool DisplayTaxRates { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.OrderTotalDiscount")]
        public string OrderTotalDiscount { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.RedeemedRewardPoints")]
        public int RedeemedRewardPoints { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.RedeemedRewardPoints")]
        public string RedeemedRewardPointsAmount { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.OrderTotal")]
        public string OrderTotal { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.RefundedAmount")]
        public string RefundedAmount { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Profit")]
        public string Profit { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Currency")]
        public string CurrencyCode { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.CurrencyRate")]

        [UIHint("DecimalN4")]
        public decimal CurrencyRate { get; set; }
        //edit totals
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Edit.OrderSubtotal")]
        public decimal OrderSubtotalInclTaxValue { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Edit.OrderSubtotal")]
        public decimal OrderSubtotalExclTaxValue { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Edit.OrderSubTotalDiscount")]
        public decimal OrderSubTotalDiscountInclTaxValue { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Edit.OrderSubTotalDiscount")]
        public decimal OrderSubTotalDiscountExclTaxValue { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Edit.OrderShipping")]
        public decimal OrderShippingInclTaxValue { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Edit.OrderShipping")]
        public decimal OrderShippingExclTaxValue { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Edit.PaymentMethodAdditionalFee")]
        public decimal PaymentMethodAdditionalFeeInclTaxValue { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Edit.PaymentMethodAdditionalFee")]
        public decimal PaymentMethodAdditionalFeeExclTaxValue { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Edit.Tax")]
        public decimal TaxValue { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Edit.TaxRates")]
        public string TaxRatesValue { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Edit.OrderTotalDiscount")]
        public decimal OrderTotalDiscountValue { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.Edit.OrderTotal")]
        public decimal OrderTotalValue { get; set; }

        //associated recurring payment id
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.RecurringPayment")]
        public string RecurringPaymentId { get; set; }

        //order status
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.OrderStatus")]
        public string OrderStatus { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.OrderStatus")]
        public int OrderStatusId { get; set; }

        //payment info
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.PaymentStatus")]
        public string PaymentStatus { get; set; }
        public PaymentStatus PaymentStatusEnum { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.PaymentMethod")]
        public string PaymentMethod { get; set; }

        //credit card info
        public bool AllowStoringCreditCardNumber { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.CardType")]

        public string CardType { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.CardName")]

        public string CardName { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.CardNumber")]

        public string CardNumber { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.CardCVV2")]

        public string CardCvv2 { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.CardExpirationMonth")]

        public string CardExpirationMonth { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.CardExpirationYear")]

        public string CardExpirationYear { get; set; }

        //misc payment info
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.AuthorizationTransactionID")]
        public string AuthorizationTransactionId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.CaptureTransactionID")]
        public string CaptureTransactionId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.SubscriptionTransactionID")]
        public string SubscriptionTransactionId { get; set; }

        //shipping info
        public bool IsShippable { get; set; }
        public bool PickUpInStore { get; set; }

        [PowerStoreResourceDisplayName("Admin.Orders.Fields.PickupAddress")]
        public AddressModel PickupAddress { get; set; }

        [PowerStoreResourceDisplayName("Admin.Orders.Fields.ShippingStatus")]
        public string ShippingStatus { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.ShippingAddress")]
        public AddressModel ShippingAddress { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.ShippingMethod")]
        public string ShippingMethod { get; set; }
        public string ShippingAdditionDescription { get; set; }
        public string ShippingAddressGoogleMapsUrl { get; set; }
        public bool CanAddNewShipments { get; set; }

        //billing info
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.BillingAddress")]
        public AddressModel BillingAddress { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.VatNumber")]
        public string VatNumber { get; set; }

        //gift cards
        public IList<GiftCard> GiftCards { get; set; }

        //items
        public bool HasDownloadableProducts { get; set; }
        public IList<OrderItemModel> Items { get; set; }

        //creation date
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }

        //checkout attributes
        public string CheckoutAttributeInfo { get; set; }


        //order notes
        [PowerStoreResourceDisplayName("Admin.Orders.OrderNotes.Fields.DisplayToCustomer")]
        public bool AddOrderNoteDisplayToCustomer { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.OrderNotes.Fields.Note")]

        public string AddOrderNoteMessage { get; set; }
        public bool AddOrderNoteHasDownload { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.OrderNotes.Fields.Download")]
        [UIHint("Download")]
        public string AddOrderNoteDownloadId { get; set; }

        //refund info
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.PartialRefund.AmountToRefund")]
        public decimal AmountToRefund { get; set; }
        public decimal MaxAmountToRefund { get; set; }
        public string PrimaryStoreCurrencyCode { get; set; }

        //workflow info
        public bool CanCancelOrder { get; set; }
        public bool CanCapture { get; set; }
        public bool CanMarkOrderAsPaid { get; set; }
        public bool CanRefund { get; set; }
        public bool CanRefundOffline { get; set; }
        public bool CanPartiallyRefund { get; set; }
        public bool CanPartiallyRefundOffline { get; set; }
        public bool CanVoid { get; set; }
        public bool CanVoidOffline { get; set; }

        //order's tags
        [PowerStoreResourceDisplayName("Admin.Orders.Fields.OrderTags")]
        public string OrderTags { get; set; }

        #region Nested Classes

        public partial class OrderItemModel : BaseEntityModel
        {
            public OrderItemModel()
            {
                ReturnRequestIds = new List<string>();
                PurchasedGiftCardIds = new List<string>();
            }
            public string ProductId { get; set; }
            public string ProductName { get; set; }
            public string VendorName { get; set; }
            public string Sku { get; set; }

            public string PictureThumbnailUrl { get; set; }

            public string UnitPriceInclTax { get; set; }
            public string UnitPriceExclTax { get; set; }
            public decimal UnitPriceInclTaxValue { get; set; }
            public decimal UnitPriceExclTaxValue { get; set; }

            public int Quantity { get; set; }

            public string DiscountInclTax { get; set; }
            public string DiscountExclTax { get; set; }
            public decimal DiscountInclTaxValue { get; set; }
            public decimal DiscountExclTaxValue { get; set; }

            public string SubTotalInclTax { get; set; }
            public string SubTotalExclTax { get; set; }
            public decimal SubTotalInclTaxValue { get; set; }
            public decimal SubTotalExclTaxValue { get; set; }

            public string AttributeInfo { get; set; }
            public string RecurringInfo { get; set; }
            public string RentalInfo { get; set; }
            public IList<string> ReturnRequestIds { get; set; }
            public IList<string> PurchasedGiftCardIds { get; set; }

            public bool IsDownload { get; set; }
            public int DownloadCount { get; set; }
            public DownloadActivationType DownloadActivationType { get; set; }
            public bool IsDownloadActivated { get; set; }
            public Guid LicenseDownloadGuid { get; set; }

            public string Commission { get; set; }
            public decimal CommissionValue { get; set; }
        }

        public partial class TaxRate : BaseModel
        {
            public string Rate { get; set; }
            public string Value { get; set; }
        }

        public partial class GiftCard : BaseModel
        {
            [PowerStoreResourceDisplayName("Admin.Orders.Fields.GiftCardInfo")]
            public string CouponCode { get; set; }
            public string Amount { get; set; }
        }

        public partial class OrderNote : BaseEntityModel
        {
            public string OrderId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Orders.OrderNotes.Fields.DisplayToCustomer")]
            public bool DisplayToCustomer { get; set; }
            [PowerStoreResourceDisplayName("Admin.Orders.OrderNotes.Fields.Note")]
            public string Note { get; set; }
            [PowerStoreResourceDisplayName("Admin.Orders.OrderNotes.Fields.Download")]
            public string DownloadId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Orders.OrderNotes.Fields.Download")]
            public Guid DownloadGuid { get; set; }
            [PowerStoreResourceDisplayName("Admin.Orders.OrderNotes.Fields.CreatedOn")]
            public DateTime CreatedOn { get; set; }
            [PowerStoreResourceDisplayName("Admin.Orders.OrderNotes.Fields.CreatedByCustomer")]
            public bool CreatedByCustomer { get; set; }
        }

        public partial class UploadLicenseModel : BaseModel
        {
            public string OrderId { get; set; }

            public string OrderItemId { get; set; }

            [UIHint("Download")]
            public string LicenseDownloadId { get; set; }

        }

        public partial class AddOrderProductModel : BaseModel
        {
            public AddOrderProductModel()
            {
                AvailableCategories = new List<SelectListItem>();
                AvailableManufacturers = new List<SelectListItem>();
                AvailableProductTypes = new List<SelectListItem>();
            }

            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductName")]

            public string SearchProductName { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchCategory")]
            public string SearchCategoryId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchManufacturer")]
            public string SearchManufacturerId { get; set; }
            [PowerStoreResourceDisplayName("Admin.Catalog.Products.List.SearchProductType")]
            public int SearchProductTypeId { get; set; }

            public IList<SelectListItem> AvailableCategories { get; set; }
            public IList<SelectListItem> AvailableManufacturers { get; set; }
            public IList<SelectListItem> AvailableProductTypes { get; set; }

            public string OrderId { get; set; }
            public int OrderNumber { get; set; }
            #region Nested classes

            public partial class ProductModel : BaseEntityModel
            {
                [PowerStoreResourceDisplayName("Admin.Orders.Products.AddNew.Name")]

                public string Name { get; set; }

                [PowerStoreResourceDisplayName("Admin.Orders.Products.AddNew.SKU")]

                public string Sku { get; set; }
            }

            public partial class ProductDetailsModel : BaseModel
            {
                public ProductDetailsModel()
                {
                    ProductAttributes = new List<ProductAttributeModel>();
                    GiftCard = new GiftCardModel();
                    Warnings = new List<string>();
                }

                public string ProductId { get; set; }

                public string OrderId { get; set; }
                public int OrderNumber { get; set; }

                public ProductType ProductType { get; set; }

                public string Name { get; set; }

                [PowerStoreResourceDisplayName("Admin.Orders.Products.AddNew.UnitPriceInclTax")]
                public decimal UnitPriceInclTax { get; set; }
                [PowerStoreResourceDisplayName("Admin.Orders.Products.AddNew.UnitPriceExclTax")]
                public decimal UnitPriceExclTax { get; set; }

                [PowerStoreResourceDisplayName("Admin.Orders.Products.AddNew.Quantity")]
                public int Quantity { get; set; }

                [PowerStoreResourceDisplayName("Admin.Orders.Products.AddNew.SubTotalInclTax")]
                public decimal SubTotalInclTax { get; set; }
                [PowerStoreResourceDisplayName("Admin.Orders.Products.AddNew.SubTotalExclTax")]
                public decimal SubTotalExclTax { get; set; }

                //product attributes
                public IList<ProductAttributeModel> ProductAttributes { get; set; }
                //gift card info
                public GiftCardModel GiftCard { get; set; }

                public List<string> Warnings { get; set; }

            }

            public partial class ProductAttributeModel : BaseEntityModel
            {
                public ProductAttributeModel()
                {
                    Values = new List<ProductAttributeValueModel>();
                }

                public string ProductAttributeId { get; set; }

                public string Name { get; set; }

                public string TextPrompt { get; set; }

                public bool IsRequired { get; set; }

                public AttributeControlType AttributeControlType { get; set; }

                public IList<ProductAttributeValueModel> Values { get; set; }
            }

            public partial class ProductAttributeValueModel : BaseEntityModel
            {
                public string Name { get; set; }

                public bool IsPreSelected { get; set; }
            }


            public partial class GiftCardModel : BaseModel
            {
                public bool IsGiftCard { get; set; }

                [PowerStoreResourceDisplayName("Admin.Orders.Products.GiftCard.RecipientName")]

                public string RecipientName { get; set; }
                [PowerStoreResourceDisplayName("Admin.Orders.Products.GiftCard.RecipientEmail")]

                public string RecipientEmail { get; set; }
                [PowerStoreResourceDisplayName("Admin.Orders.Products.GiftCard.SenderName")]

                public string SenderName { get; set; }
                [PowerStoreResourceDisplayName("Admin.Orders.Products.GiftCard.SenderEmail")]

                public string SenderEmail { get; set; }
                [PowerStoreResourceDisplayName("Admin.Orders.Products.GiftCard.Message")]

                public string Message { get; set; }

                public GiftCardType GiftCardType { get; set; }
            }
            #endregion
        }

        public partial class UsedDiscountModel : BaseModel
        {
            public string DiscountId { get; set; }
            public string DiscountName { get; set; }
        }

        #endregion
    }


    public partial class OrderAggreratorModel : BaseModel
    {
        //aggergator properties
        public string aggregatorprofit { get; set; }
        public string aggregatorshipping { get; set; }
        public string aggregatortax { get; set; }
        public string aggregatortotal { get; set; }
    }
}
