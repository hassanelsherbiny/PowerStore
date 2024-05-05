using PowerStore.Web.Models.Common;
using MediatR;
using System.Collections.Generic;

namespace PowerStore.Web.Features.Models.Common
{
    public class GetStatesProvince : IRequest<IList<StateProvinceModel>>
    {
        public string CountryId { get; set; }
        public bool AddSelectStateItem { get; set; }
    }
}
