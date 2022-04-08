using System;

namespace Problem3
{
    public class Mail
    {
        public string SenderName { get; set; }
        public string SenderAddress { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverAddress { get; set; }
        public decimal PostalCost { get; set; }
        public decimal Weight { get; set; }
        public MailType Type { get; set; }
        public bool isFlagged { get; set; }
    }
}
