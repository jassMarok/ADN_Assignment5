using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    /// <summary>
    /// This handler takes care of all Mail that needs to be sent to a postal code in Hamilton, Ontario.
    /// </summary>
    public class HamiltonMailHandler : MailHandler
    {
        /// <summary>
        /// Constructor for HamiltonMailHandler
        /// Defines the postal codes for the city of Hamilton and sets up boxes to sort mail into.
        /// </summary>
        public HamiltonMailHandler() : base()
        {
            MailBoxAddresses = new string[] { "L8V", "L8L", "L75", "L8N", "L8W" };
            SetUpMailBoxes();
        }

        /// <summary>
        /// Specify that the handler will be handling Mail with "Hamilton" in the mailing address
        /// </summary>
        public override string AddressResource => "Hamilton";

    }

}
