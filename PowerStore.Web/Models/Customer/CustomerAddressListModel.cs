using PowerStore.Core.Models;
using PowerStore.Web.Models.Common;
using System.Collections.Generic;

namespace PowerStore.Web.Models.Customer
{
    public partial class CustomerAddressListModel : BaseModel
    {
        public CustomerAddressListModel()
        {
            Addresses = new List<AddressModel>();
        }

        public IList<AddressModel> Addresses { get; set; }
    }
}