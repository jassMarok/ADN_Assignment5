using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    class TorontoMailHandler :IMailHandler
    {
        public TorontoMailHandler()
        {

        }

        public string Resource => "Toronto";

        private string[] PostalCodes = { "M3C", "M4C", "M4E" };

        public void Handle(Mail mail)
        {
            bool sorted = false;
            foreach (var code in PostalCodes)
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
