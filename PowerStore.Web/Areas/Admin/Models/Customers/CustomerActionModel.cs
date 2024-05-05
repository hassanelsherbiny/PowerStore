using PowerStore.Domain.Customers;
using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Areas.Admin.Models.Customers
{
    public partial class CustomerActionModel : BaseEntityModel
    {
        public CustomerActionModel()
        {
            this.ActionType = new List<SelectListItem>();
            this.Banners = new List<SelectListItem>();
            this.InteractiveForms = new List<SelectListItem>();
            this.MessageTemplates = new List<SelectListItem>();
            this.CustomerRoles = new List<SelectListItem>();
            this.CustomerTags = new List<SelectListItem>();

        }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerAction.Fields.Name")]
        public string Name { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerAction.Fields.Active")]
        public bool Active { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerAction.Fields.ActionTypeId")]
        public string ActionTypeId { get; set; }
        public IList<SelectListItem> ActionType { get; set; }


        [PowerStoreResourceDisplayName("Admin.Customers.CustomerAction.Fields.ConditionId")]
        public int ConditionId { get; set; }
        public int ConditionCount { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerAction.Fields.ReactionType")]
        public int ReactionTypeId { get; set; }
        public CustomerReactionTypeEnum ReactionType {
            get { return (CustomerReactionTypeEnum)ReactionTypeId; }
            set { this.ReactionTypeId = (int)value; }
        }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerAction.Fields.Banner")]
        public string BannerId { get; set; }
        public IList<SelectListItem> Banners { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerAction.Fields.InteractiveForm")]
        public string InteractiveFormId { get; set; }
        public IList<SelectListItem> InteractiveForms { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerAction.Fields.MessageTemplate")]
        public string MessageTemplateId { get; set; }
        public IList<SelectListItem> MessageTemplates { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerAction.Fields.CustomerRole")]
        public string CustomerRoleId { get; set; }
        public IList<SelectListItem> CustomerRoles { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerAction.Fields.CustomerTag")]
        public string CustomerTagId { get; set; }
        public IList<SelectListItem> CustomerTags { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerAction.Fields.StartDateTime")]
        [UIHint("DateTimeNullable")]
        public DateTime StartDateTime { get; set; }

        [PowerStoreResourceDisplayName("Admin.Customers.CustomerAction.Fields.EndDateTime")]
        [UIHint("DateTimeNullable")]
        public DateTime EndDateTime { get; set; }

    }



}