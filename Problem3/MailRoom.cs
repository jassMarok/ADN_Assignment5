using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem3
{
    public class MailRoom
    {
        private List<IMailHandler> handlers = new List<IMailHandler>();

        public MailRoom()
        {
            this.handlers.AddRange(typeof(MailRoom).Assembly.DefinedTypes.Where(c => c == typeof(IMailHandler)
                                                                            && !c.IsAbstract
                                                                            && c.IsClass)
                                                  .Select(t => (IMailHandler)Activator.CreateInstance(t)));
        }

        public void Handle(Mail mail)
        {
            var handler = this.handlers.FirstOrDefault(c => mail.ReceiverAddress.Contains(c.Resource));

            if (handler == null)
            {
                throw new InvalidOperationException("Unable to locate handler for resource");
            }
            
            handler.Handle(mail);
        }
    }
}
