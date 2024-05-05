using PowerStore.Framework.Mapping;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PowerStore.Framework.Mvc.Models;

namespace PowerStore.Web.Areas.Admin.Models.Documents
{
    public class DocumentModel : BaseEntityModel, IAclMappingModel, IStoreMappingModel
    {
        public DocumentModel()
        {
            AvailableDocumentTypes = new List<SelectListItem>();
            AvailableSelesEmployees = new List<SelectListItem>();
        }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.Number")]
        public string Number { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.SeId")]
        public string SeId { get; set; }
        public IList<SelectListItem> AvailableSelesEmployees { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.Description")]
        public string Description { get; set; }

        public string ParentDocumentId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.Picture")]
        [UIHint("Picture")]
        public string PictureId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.Download")]
        [UIHint("Download")]
        public string DownloadId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.Published")]
        public bool Published { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.Flag")]
        public string Flag { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.Link")]
        public string Link { get; set; }

        public string CustomerId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.Status")]
        public int StatusId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.Reference")]
        public int ReferenceId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.Object")]
        public string ObjectId { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.DocumentType")]
        public string DocumentTypeId { get; set; }
        public IList<SelectListItem> AvailableDocumentTypes { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.CustomerEmail")]
        public string CustomerEmail { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.Username")]
        public string Username { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.CurrencyCode")]
        public string CurrencyCode { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.TotalAmount")]
        public decimal TotalAmount { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.OutstandAmount")]
        public decimal OutstandAmount { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.Quantity")]
        public int Quantity { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.DocDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? DocDate { get; set; }

        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.DueDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? DueDate { get; set; }

        //ACL
        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.SubjectToAcl")]
        public bool SubjectToAcl { get; set; }
        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.AclCustomerRoles")]
        public List<CustomerRoleModel> AvailableCustomerRoles { get; set; }
        public string[] SelectedCustomerRoleIds { get; set; }

        //Store mapping
        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.LimitedToStores")]
        public bool LimitedToStores { get; set; }
        [PowerStoreResourceDisplayName("Admin.Documents.Document.Fields.AvailableStores")]
        public List<StoreModel> AvailableStores { get; set; }
        public string[] SelectedStoreIds { get; set; }
    }
}
