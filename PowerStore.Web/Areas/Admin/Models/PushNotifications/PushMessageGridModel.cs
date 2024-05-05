using PowerStore.Core;
using PowerStore.Domain;
using System;

namespace PowerStore.Web.Areas.Admin.Models.PushNotifications
{
    public class PushMessageGridModel : BaseEntity
    {
        public string Title { get; set; }

        public string Text { get; set; }

        public DateTime SentOn { get; set; }

        public int NumberOfReceivers { get; set; }
    }
}
