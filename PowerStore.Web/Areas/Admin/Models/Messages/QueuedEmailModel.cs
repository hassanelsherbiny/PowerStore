using PowerStore.Core.ModelBinding;
using PowerStore.Core.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace PowerStore.Web.Areas.Admin.Models.Messages
{
    public partial class QueuedEmailModel : BaseEntityModel
    {
        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.Id")]
        public override string Id { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.Priority")]
        public string PriorityName { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.From")]

        public string From { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.FromName")]

        public string FromName { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.To")]

        public string To { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.ToName")]

        public string ToName { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.ReplyTo")]

        public string ReplyTo { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.ReplyToName")]

        public string ReplyToName { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.CC")]

        public string CC { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.Bcc")]

        public string Bcc { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.Subject")]

        public string Subject { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.Body")]

        public string Body { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.AttachmentFilePath")]

        public string AttachmentFilePath { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.AttachedDownload")]
        [UIHint("Download")]
        public string AttachedDownloadId { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.CreatedOn")]
        public DateTime CreatedOn { get; set; }
        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.SendImmediately")]
        public bool SendImmediately { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.DontSendBeforeDate")]
        [UIHint("DateTimeNullable")]
        public DateTime? DontSendBeforeDate { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.SentTries")]
        public int SentTries { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.SentOn")]
        public DateTime? SentOn { get; set; }

        [PowerStoreResourceDisplayName("Admin.System.QueuedEmails.Fields.EmailAccountName")]

        public string EmailAccountName { get; set; }
    }
}