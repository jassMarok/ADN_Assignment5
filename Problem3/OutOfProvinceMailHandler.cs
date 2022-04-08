using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public class OutOfProvinceMailHandler
    {
        public OutOfProvinceMailHandler()
        {

        }

        public string Resource => "Canada";

        private string[] ProvincesAndTerritories = { "AB", "BC", "MB", "NB", "NL", "NT", "NU", "ON", "PE", "QC", "SK", "YT"};

        public void Handle(Mail mail)
        {
            bool sorted = false;
            foreach (var code in ProvincesAndTerritories)
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
