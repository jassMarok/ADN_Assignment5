using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public abstract class MailHandler
    {
        public abstract string Resource { get; }
        public string[] MailBoxes { get; set; }

        public virtual void Handle(Mail mail)
        {
            bool sorted = false;
            foreach (var code in MailBoxes)
            {
                if (mail.ReceiverAddress.Contains(code))
                {
                    Console.WriteLine($"Mail from {mail.SenderName} going to {mail.ReceiverName} placed in {code} mailbox");
                    sorted = true;
                    break;
                }
            }

            if (!sorted)
            {
                mail.isFlagged = true;
                Console.WriteLine($"Mail from { mail.SenderName} going to { mail.ReceiverName} placed in review queue");
            }

        }
    }
}
