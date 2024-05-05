using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;

namespace PowerStore.Web.Areas.Admin.Models.Payments
{
    public partial class PaymentMethodModel : BaseModel
    {
        [PowerStoreResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.FriendlyName")]
        
        public string FriendlyName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.SystemName")]
        
        public string SystemName { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.IsActive")]
        public bool IsActive { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.Logo")]
        public string LogoUrl { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.SupportCapture")]
        public bool SupportCapture { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.SupportPartiallyRefund")]
        public bool SupportPartiallyRefund { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.SupportRefund")]
        public bool SupportRefund { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.SupportVoid")]
        public bool SupportVoid { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.RecurringPaymentType")]
        public string RecurringPaymentType { get; set; }

        [PowerStoreResourceDisplayName("Admin.Configuration.Payment.Methods.Fields.Configure")]
        public string ConfigurationUrl { get; set; }
    }
}