using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Models.Vendors
{
    public partial class VendorAddressModel : BaseEntityModel
    {
        public VendorAddressModel()
        {
            AvailableCountries = new List<SelectListItem>();
            AvailableStates = new List<SelectListItem>();
        }

        public bool CompanyEnabled { get; set; }
        public bool CompanyRequired { get; set; }
        [PowerStoreResourceDisplayName("Account.VendorInfo.Company")]
        public string Company { get; set; }
        public bool CountryEnabled { get; set; }
        [PowerStoreResourceDisplayName("Account.VendorInfo.Country")]
        public string CountryId { get; set; }
        [PowerStoreResourceDisplayName("Account.VendorInfo.Country")]
        public string CountryName { get; set; }
        public bool StateProvinceEnabled { get; set; }
        [PowerStoreResourceDisplayName("Account.VendorInfo.StateProvince")]
        public string StateProvinceId { get; set; }
        [PowerStoreResourceDisplayName("Account.VendorInfo.StateProvince")]
        public string StateProvinceName { get; set; }
        public bool CityEnabled { get; set; }
        public bool CityRequired { get; set; }
        [PowerStoreResourceDisplayName("Account.VendorInfo.City")]
        public string City { get; set; }
        public bool StreetAddressEnabled { get; set; }
        public bool StreetAddressRequired { get; set; }
        [PowerStoreResourceDisplayName("Account.VendorInfo.Address1")]
        public string Address1 { get; set; }
        public bool StreetAddress2Enabled { get; set; }
        public bool StreetAddress2Required { get; set; }
        [PowerStoreResourceDisplayName("Account.VendorInfo.Address2")]
        public string Address2 { get; set; }
        public bool ZipPostalCodeEnabled { get; set; }
        public bool ZipPostalCodeRequired { get; set; }
        [PowerStoreResourceDisplayName("Account.VendorInfo.ZipPostalCode")]
        public string ZipPostalCode { get; set; }
        public bool PhoneEnabled { get; set; }
        public bool PhoneRequired { get; set; }
        [DataType(DataType.PhoneNumber)]
        [PowerStoreResourceDisplayName("Account.VendorInfo.PhoneNumber")]
        public string PhoneNumber { get; set; }
        public bool FaxEnabled { get; set; }
        public bool FaxRequired { get; set; }
        [PowerStoreResourceDisplayName("Account.VendorInfo.FaxNumber")]
        public string FaxNumber { get; set; }
        public IList<SelectListItem> AvailableCountries { get; set; }
        public IList<SelectListItem> AvailableStates { get; set; }
    }
}