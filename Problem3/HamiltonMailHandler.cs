using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public class HamiltonMailHandler : MailHandler
    {
        public HamiltonMailHandler() : base()
        {
            MailBoxAddresses = new string[] { "L8V", "L8L", "L75" };
            SetUpMailBoxes();
        }

        public override string Resource => "Hamilton";

    }

}
