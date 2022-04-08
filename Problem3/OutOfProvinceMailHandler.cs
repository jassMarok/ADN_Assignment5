﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public class OutOfProvinceMailHandler : MailHandler
    {
        public OutOfProvinceMailHandler()
        {
            MailBoxes = new string[] { "AB", "BC", "MB", "NB", "NL", "NT", "NU", "ON", "PE", "QC", "SK", "YT" };
        }

        public override string Resource => "Canada";
    }
}
