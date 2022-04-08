using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem3
{
    /// <summary>
    /// MailRoom where Mail will be received and sent to handlers
    /// (Reactor class)
    /// </summary>
    public class MailRoom
    {
        /// <summary>
        /// List of handlers
        /// </summary>
        private List<MailHandler> handlers = new List<MailHandler>();

        /// <summary>
        /// Constructor for MailRoom
        /// Hooks up all handlers when MailRoom is created
        /// </summary>
        public MailRoom()
        {
            this.handlers.AddRange(typeof(MailRoom).Assembly.DefinedTypes.Where(c => typeof(MailHandler).IsAssignableFrom(c)
                                                                            && !c.IsAbstract
                                                                            && c.IsClass)
                                                  .Select(t => (MailHandler)Activator.CreateInstance(t)));
        }

        /// <summary>
        /// Sends the mail to their corresponding handler
        /// </summary>
        /// <param name="mail">Mail object</param>
        public void Handle(Mail mail)
        {
            var handler = this.handlers.FirstOrDefault(c => mail.ReceiverAddress.Contains(c.AddressResource));

            if (handler == null)
            {
                throw new InvalidOperationException("Unable to locate handler for resource");
            }
            
            handler.Handle(mail);
        }
    }
}
