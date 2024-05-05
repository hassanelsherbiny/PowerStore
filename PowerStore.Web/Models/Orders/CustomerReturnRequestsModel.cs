using PowerStore.Core.Models;
using System;
using System.Collections.Generic;

namespace PowerStore.Web.Models.Orders
{
    public partial class CustomerReturnRequestsModel : BaseModel
    {
        public CustomerReturnRequestsModel()
        {
            Items = new List<ReturnRequestModel>();
        }

        public IList<ReturnRequestModel> Items { get; set; }

        #region Nested classes
        public partial class ReturnRequestModel : BaseEntityModel
        {
            public int ReturnNumber { get; set; }
            public string ReturnRequestStatus { get; set; }
            public DateTime CreatedOn { get; set; }
            public int ProductsCount { get; set; }
            public string ReturnTotal { get; set; }
        }
        #endregion
    }
}