using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class EmailSender
    {
        public event Action<object, string> Send;
        public void BulkEmailSender(List<string> email, string subject, string body)
        {
            foreach (var emailItem in email)
            {
                Console.WriteLine("Send mail to :" + emailItem);
            }
            Send.Invoke(this, "Emails Sent");
        }
    }
}
