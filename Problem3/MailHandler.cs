using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public abstract class MailHandler
    {
        public MailHandler()
        {
            foreach(var address in MailBoxAddresses)
            {
                MailBoxes.Add(new List<Mail>());
            }
        }

        public abstract string Resource { get; }
        public string[] MailBoxAddresses { get; set; }
        public List<List<Mail>> MailBoxes;

        public virtual void Handle(Mail mail)
        {
            bool sorted = false;
            for (int i = 0; i < MailBoxAddresses.Length; i++)
            {
                if (mail.ReceiverAddress.Contains(MailBoxAddresses[i]))
                {
                    Console.WriteLine($"Mail from {mail.SenderName} going to {mail.ReceiverName} placed in {MailBoxAddresses[i]} mailbox");
                    MailBoxes[i].Add(mail);
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
