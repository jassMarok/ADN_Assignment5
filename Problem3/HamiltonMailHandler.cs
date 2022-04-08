using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public class HamiltonMailHandler : IMailHandler
    {
        public HamiltonMailHandler()
        {

        }

        public string Resource => "Hamilton";

        public string[] PostalCodes = { "L8V", "L8L", "L75" };
        
        public void Handle(Mail mail)
        {
            bool sorted = false;
            foreach(var code in PostalCodes)
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
