using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public abstract class MailHandler
    {
        public MailHandler()
        {
            MailBoxes = new List<List<Mail>>();
        }

        public abstract string Resource { get; }
        public string[] MailBoxAddresses { get; set; }
        public List<List<Mail>> MailBoxes;

        protected void SetUpMailBoxes()
        {
            foreach (var address in MailBoxAddresses)
            {
                MailBoxes.Add(new List<Mail>());
            }
        }

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
