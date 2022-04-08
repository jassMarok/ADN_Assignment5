using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public class PackageHandler : Handler, HamiltonMailHandler
    {
        public PackageHandler()
        {

        }

        public string Resource => "Package";

        public void Handle(Mail mail)
        {
            throw new NotImplementedException();
        }

        public override void HandleRequest(Mail mail)
        {
            throw new NotImplementedException();
        }
    }
}
