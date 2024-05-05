using PowerStore.Framework.Localization;
using PowerStore.Core.Models;
using PowerStore.Core.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PowerStore.Domain.Localization;

namespace PowerStore.Web.Areas.Admin.Models.Orders
{
    public class OrderTagModel : BaseEntityModel, ILocalizedModel<OrderTagLocalizedModel>
    {
        public OrderTagModel()
        {
            Locales = new List<OrderTagLocalizedModel>();
        }

        [PowerStoreResourceDisplayName("Admin.Orders.OrderTags.Fields.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Orders.OrderTags.Fields.OrderCount")]
        public int OrderCount { get; set; }
        public IList<OrderTagLocalizedModel> Locales { get; set; }
    }

    public partial class OrderTagLocalizedModel : ILocalizedModelLocal
    {
        public string LanguageId { get; set; }
        [PowerStoreResourceDisplayName("Admin.Orders.OrderTags.Fields.Name")]
        public string Name { get; set; }

    }
}
