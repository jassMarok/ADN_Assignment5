using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public class HamiltonMailHandler : MailHandler
    {
        public HamiltonMailHandler()
        {
            MailBoxes = new string[] { "L8V", "L8L", "L75" };
        }

        public override string Resource => "Hamilton";

    }

}
