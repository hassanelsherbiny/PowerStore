using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Areas.Admin.Models.Customers
{
    public partial class CustomerListModel : BaseModel
    {
        public CustomerListModel()
        {
            AvailableCustomerTags = new List<SelectListItem>();
            SearchCustomerTagIds = new List<string>();
            SearchCustomerRoleIds = new List<string>();
            AvailableCustomerRoles = new List<SelectListItem>();
        }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.List.CustomerRoles")]
        
        public IList<SelectListItem> AvailableCustomerRoles { get; set; }


        [PowerStoreResourceDisplayName("Admin.Customers.Customers.List.CustomerRoles")]
        [UIHint("MultiSelect")]
        public IList<string> SearchCustomerRoleIds { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.List.CustomerTags")]
        public IList<SelectListItem> AvailableCustomerTags { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.List.CustomerTags")]
        [UIHint("MultiSelect")]
        public IList<string> SearchCustomerTagIds { get; set; }


        [PowerStoreResourceDisplayName("Admin.Customers.Customers.List.SearchEmail")]
        
        public string SearchEmail { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.List.SearchUsername")]
        
        public string SearchUsername { get; set; }
        public bool UsernamesEnabled { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.List.SearchFirstName")]
        
        public string SearchFirstName { get; set; }
        [PowerStoreResourceDisplayName("Admin.Customers.Customers.List.SearchLastName")]
        
        public string SearchLastName { get; set; }


        [PowerStoreResourceDisplayName("Admin.Customers.Customers.List.SearchCompany")]
        
        public string SearchCompany { get; set; }
        public bool CompanyEnabled { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.List.SearchPhone")]
        
        public string SearchPhone { get; set; }
        public bool PhoneEnabled { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.Customers.List.SearchZipCode")]
        
        public string SearchZipPostalCode { get; set; }
        public bool ZipPostalCodeEnabled { get; set; }
    }
}