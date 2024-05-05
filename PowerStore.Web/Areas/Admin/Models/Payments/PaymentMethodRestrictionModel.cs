using PowerStore.Core.Models;
using PowerStore.Framework.Mvc.Models;
using PowerStore.Web.Areas.Admin.Models.Directory;
using PowerStore.Web.Areas.Admin.Models.Shipping;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Payments
{
    public partial class PaymentMethodRestrictionModel : BaseModel
    {
        public PaymentMethodRestrictionModel()
        {
            AvailablePaymentMethods = new List<PaymentMethodModel>();
            AvailableCountries = new List<CountryModel>();
            AvailableCustomerRoles = new List<CustomerRoleModel>();
            AvailableShippingMethods = new List<ShippingMethodModel>();
            Resticted = new Dictionary<string, IDictionary<string, bool>>();
            RestictedRole = new Dictionary<string, IDictionary<string, bool>>();
            RestictedShipping = new Dictionary<string, IDictionary<string, bool>>();
        }
        public IList<PaymentMethodModel> AvailablePaymentMethods { get; set; }
        public IList<CountryModel> AvailableCountries { get; set; }
        public IList<CustomerRoleModel> AvailableCustomerRoles { get; set; }
        public IList<ShippingMethodModel> AvailableShippingMethods { get; set; }

        //[payment method system name] / [customer role id] / [resticted]
        public IDictionary<string, IDictionary<string, bool>> Resticted { get; set; }
        public IDictionary<string, IDictionary<string, bool>> RestictedRole { get; set; }
        public IDictionary<string, IDictionary<string, bool>> RestictedShipping { get; set; }
    }

}