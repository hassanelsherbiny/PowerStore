using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Models.Common
{
    public partial class AddressModel : BaseEntityModel
    {
        public AddressModel()
        {
            AvailableCountries = new List<SelectListItem>();
            AvailableStates = new List<SelectListItem>();
            CustomAddressAttributes = new List<AddressAttributeModel>();
        }

        [PowerStoreResourceDisplayName("Address.Fields.FirstName")]
        public string FirstName { get; set; }
        [PowerStoreResourceDisplayName("Address.Fields.LastName")]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        [PowerStoreResourceDisplayName("Address.Fields.Email")]
        public string Email { get; set; }


        public bool CompanyEnabled { get; set; }
        public bool CompanyRequired { get; set; }
        [PowerStoreResourceDisplayName("Address.Fields.Company")]
        public string Company { get; set; }

        public bool VatNumberEnabled { get; set; }
        public bool VatNumberRequired { get; set; }
        [PowerStoreResourceDisplayName("Address.Fields.VatNumber")]
        public string VatNumber { get; set; }

        public bool CountryEnabled { get; set; }
        [PowerStoreResourceDisplayName("Address.Fields.Country")]
        public string CountryId { get; set; }
        [PowerStoreResourceDisplayName("Address.Fields.Country")]
        public string CountryName { get; set; }

        public bool StateProvinceEnabled { get; set; }
        [PowerStoreResourceDisplayName("Address.Fields.StateProvince")]
        public string StateProvinceId { get; set; }
        [PowerStoreResourceDisplayName("Address.Fields.StateProvince")]
        public string StateProvinceName { get; set; }

        public bool CityEnabled { get; set; }
        public bool CityRequired { get; set; }
        [PowerStoreResourceDisplayName("Address.Fields.City")]
        public string City { get; set; }

        public bool StreetAddressEnabled { get; set; }
        public bool StreetAddressRequired { get; set; }
        [PowerStoreResourceDisplayName("Address.Fields.Address1")]
        public string Address1 { get; set; }

        public bool StreetAddress2Enabled { get; set; }
        public bool StreetAddress2Required { get; set; }
        [PowerStoreResourceDisplayName("Address.Fields.Address2")]
        public string Address2 { get; set; }

        public bool ZipPostalCodeEnabled { get; set; }
        public bool ZipPostalCodeRequired { get; set; }
        [PowerStoreResourceDisplayName("Address.Fields.ZipPostalCode")]
        public string ZipPostalCode { get; set; }

        public bool PhoneEnabled { get; set; }
        public bool PhoneRequired { get; set; }
        [DataType(DataType.PhoneNumber)]
        [PowerStoreResourceDisplayName("Address.Fields.PhoneNumber")]
        public string PhoneNumber { get; set; }

        public bool FaxEnabled { get; set; }
        public bool FaxRequired { get; set; }

        [PowerStoreResourceDisplayName("Address.Fields.FaxNumber")]
        public string FaxNumber { get; set; }

        public IList<SelectListItem> AvailableCountries { get; set; }
        public IList<SelectListItem> AvailableStates { get; set; }


        public string FormattedCustomAddressAttributes { get; set; }
        public IList<AddressAttributeModel> CustomAddressAttributes { get; set; }
    }
}