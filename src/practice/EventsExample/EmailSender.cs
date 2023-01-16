using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    public class EmailSender
    {
        public event Action<string> OnFinished;
        public void EmailSendes(List<string> emails, string subject, string body)
        {
            foreach (var email in emails)
            {
                Console.WriteLine("Sending email to : " + email);
            }
            OnFinished.Invoke("Email Sent");
        }
    }
}
