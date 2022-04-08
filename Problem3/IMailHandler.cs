using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public interface IMailHandler
    {
        public abstract string Resource { get; }
        public abstract void Handle(Mail mail);
    }
}
