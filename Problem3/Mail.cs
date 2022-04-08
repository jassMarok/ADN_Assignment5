using System;

namespace Problem3
{
    /// <summary>
    /// Mail class for instantiating Mail objects
    /// </summary>
    public class Mail
    {
        /// <summary>
        /// Sender name
        /// </summary>
        public string SenderName { get; set; }

        /// <summary>
        /// Sender's address, a.k.a. return address
        /// </summary>
        public string SenderAddress { get; set; }

        /// <summary>
        /// Receiver's name
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// Receiver's address
        /// </summary>
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// Cost of delivery
        /// </summary>
        public decimal PostalCost { get; set; }

        /// <summary>
        /// Weight of the mail
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// Defines whether the mail is a letter or a package
        /// </summary>
        public MailType Type { get; set; }

        /// <summary>
        /// Flagged mail need to be reviewed before they can be delivered
        /// </summary>
        public bool isFlagged { get; set; }
    }
}
