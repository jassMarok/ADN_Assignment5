using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    class TorontoMailHandler : MailHandler
    {
        public TorontoMailHandler() : base()
        {
            MailBoxAddresses = new string[] { "M3C", "M4C", "M4E" };
        }

        public override string Resource => "Toronto";

    }
}
