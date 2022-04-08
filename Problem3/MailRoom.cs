using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem3
{
    public class MailRoom
    {
        private List<MailHandler> handlers = new List<MailHandler>();

        public MailRoom()
        {
            this.handlers.AddRange(typeof(MailRoom).Assembly.DefinedTypes.Where(c => typeof(MailHandler).IsAssignableFrom(c)
                                                                            && !c.IsAbstract
                                                                            && c.IsClass)
                                                  .Select(t => (MailHandler)Activator.CreateInstance(t)));
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
