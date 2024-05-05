using PowerStore.Domain.Vendors;
using PowerStore.Services.Common;
using System;

namespace PowerStore.Services.Vendors
{
    public static class VendorExtensions
    {
        /// <summary>
        /// Formats the vendor note text
        /// </summary>
        /// <param name="vendorNote">Vendor note</param>
        /// <returns>Formatted text</returns>
        public static string FormatVendorNoteText(this VendorNote vendorNote)
        {
            if (vendorNote == null)
                throw new ArgumentNullException("vendorNote");

            return FormatText.ConvertText(vendorNote.Note);
        }
    }
}
