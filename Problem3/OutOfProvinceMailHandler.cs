using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    /// <summary>
    /// This handler takes care of all Mail that needs to be sent to an address outside of the Sender's province/territory, but within Canada.
    /// </summary>
    public class OutOfProvinceMailHandler : MailHandler
    {
        /// <summary>
        /// Constructor for OutOfProvinceHandler
        /// Defines the codes for provinces and territories in Canada,
        /// and sets up boxes to sort mail into
        /// </summary>
        public OutOfProvinceMailHandler() : base()
        {
            MailBoxAddresses = new string[] { "AB", "BC", "MB", "NB", "NL", "NT", "NU", "ON", "PE", "QC", "SK", "YT" };
            SetUpMailBoxes();
        }

        /// <summary>
        /// Specify that the Handler will be handling Mail with "Canada" in the mailing address
        /// </summary>
        public override string AddressResource => "Canada";
    }
}
