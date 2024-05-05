using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PowerStore.Plugin.Payments.BrainTree.Models
{
    public class PaymentInfoModel : BaseModel
    {
        public PaymentInfoModel()
        {
            ExpireMonths = new List<SelectListItem>();
            ExpireYears = new List<SelectListItem>();
        }

        [PowerStoreResourceDisplayName("Payment.SelectCreditCard")]
        public string CreditCardType { get; set; }

        [PowerStoreResourceDisplayName("Payment.CardholderName")]

        public string CardholderName { get; set; }

        [PowerStoreResourceDisplayName("Payment.CardNumber")]
        public string CardNumber { get; set; }

        [PowerStoreResourceDisplayName("Payment.ExpirationDate")]
        public string ExpireMonth { get; set; }

        [PowerStoreResourceDisplayName("Payment.ExpirationDate")]
        public string ExpireYear { get; set; }

        public IList<SelectListItem> ExpireMonths { get; set; }

        public IList<SelectListItem> ExpireYears { get; set; }

        [PowerStoreResourceDisplayName("Payment.CardCode")]
        public string CardCode { get; set; }

        public string CardNonce { get; set; }
        public string Errors { get; set; }

    }
}