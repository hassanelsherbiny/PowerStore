using PowerStore.Domain.Shipping;
using PowerStore.Services.Common;
using System;

namespace PowerStore.Services.Shipping
{
    public static class ShipmentExtensions
    {
        /// <summary>
        /// Formats the order note text
        /// </summary>
        /// <param name="orderNote">Order note</param>
        /// <returns>Formatted text</returns>
        public static string FormatOrderNoteText(this ShipmentNote shipmentNote)
        {
            if (shipmentNote == null)
                throw new ArgumentNullException("orderNote");

            return FormatText.ConvertText(shipmentNote.Note);
        }

    }
}
