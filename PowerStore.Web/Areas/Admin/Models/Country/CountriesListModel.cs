using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace PowerStore.Web.Areas.Admin.Models.Country
{
    public partial class CountriesListModel : BaseModel
    {
        public CountriesListModel() { }

        [PowerStoreResourceDisplayName("Admin.Configuration.Countries.Fields.Name")]
        public string CountryName { get; set; }

    }
}
