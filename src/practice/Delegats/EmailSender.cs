using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class EmailSender
    {
        //public delegate string HyperlinkGenerator(int Id, string email);
        //public void BlukEmailSender( int campaignId, List<string> emailId, HyperlinkGenerator hyperlink)
        //new feature last string ta return type jodi return type na thake method a tahole func ar jaigai action hobe
        public void BlukEmailSender(int campaignId, List<string> emailId, Func<int, string, string> hyperlink)
        {
            foreach (var email in emailId)
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("<html><head></head><body>");
                builder.Append("<a href='").Append(hyperlink(campaignId, email));
                builder.Append("'/></body></html>");
            }

        }
    }
}
