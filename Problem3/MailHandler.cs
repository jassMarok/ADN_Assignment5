using System;
using System.Collections.Generic;
using System.Text;

/*
 * Christie Keopradith 000757945 certify that this material is my original work. 
 * No other person's work has been used without due acknowledgement.
 */

namespace Problem3
{
    /// <summary>
    /// Abstract MailHandler class that all MailHandlers should derive from 
    /// </summary>
    public abstract class MailHandler
    {
        /// <summary>
        /// Constructor for MailHandler
        /// Initializes MailBoxes to hold mail
        /// </summary>
        public MailHandler()
        {
            MailBoxes = new List<List<Mail>>();
        }

        /// <summary>
        /// The Resource property will specify what geographical area the Handler will be taking care of.
        /// </summary>
        public abstract string AddressResource { get; }

        /// <summary>
        /// String array of addresses for each mailbox
        /// </summary>
        public string[] MailBoxAddresses { get; set; }

        /// <summary>
        /// Boxes to hold the mail after they have been assigned
        /// </summary>
        public List<List<Mail>> MailBoxes;

        /// <summary>
        /// Initialize MailBoxes
        /// </summary>
        protected void SetUpMailBoxes()
        {
            foreach (var address in MailBoxAddresses)
            {
                MailBoxes.Add(new List<Mail>());
            }
        }

        /// <summary>
        /// Places mail into designated mailbox, or flags the mail to be reviewed if there is no designated mailbox
        /// </summary>
        /// <param name="mail">Mail object</param>
        public virtual void Handle(Mail mail)
        {
            bool sorted = false;
            for (int i = 0; i < MailBoxAddresses.Length; i++)
            {
                if (mail.ReceiverAddress.Contains(MailBoxAddresses[i]))
                {
                    Console.WriteLine($"Mail going to {mail.ReceiverAddress} placed in {MailBoxAddresses[i]} mailbox");
                    MailBoxes[i].Add(mail);
                    sorted = true;
                    break;
                }
            }

            if (!sorted)
            {
                mail.isFlagged = true;
                Console.WriteLine($"Mail going to { mail.ReceiverAddress} placed in review queue");
            }

        }
    }
}
