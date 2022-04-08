using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    /// <summary>
    /// This handler takes care of all Mail that needs to be sent to a postal code in Toronto, Ontario.
    /// </summary>
    class TorontoMailHandler : MailHandler
    {
        /// <summary>
        /// Constructor for HamiltonMailHandler
        /// Defines the postal codes for the city of Toronto and sets up boxes to sort mail into.
        /// </summary>
        public TorontoMailHandler() : base()
        {
            MailBoxAddresses = new string[] { "M3C", "M4C", "M4E" };
            SetUpMailBoxes();
        }

        /// <summary>
        /// Specify that the handler will be handling Mail with "Toronto" in the mailing address
        /// </summary>
        public override string AddressResource => "Toronto";

    }
}
