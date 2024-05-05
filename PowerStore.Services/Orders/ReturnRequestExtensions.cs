using PowerStore.Domain.Orders;
using PowerStore.Services.Common;
using System;

namespace PowerStore.Services.Orders
{
    public static class ReturnRequestExtensions
    {
        public static string FormatReturnRequestNoteText(this ReturnRequestNote returnRequestNote)
        {
            if (returnRequestNote == null)
                throw new ArgumentNullException("returnRequestNote");

            return FormatText.ConvertText(returnRequestNote.Note);
        }
    }
}
