﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public class EmailSender
    {
        public delegate string HyperlinkGenerator(int c, string e);
        public void SendBulkEmail(int campaignId, List<string> emailAddress, HyperlinkGenerator hyperlinkGenerator)
        {
            foreach(var email in emailAddress)
            {
                StringBuilder builder= new StringBuilder();
                builder.Append("<html><head></head><body>");
                builder.Append("<a href='").Append(hyperlinkGenerator(campaignId, email));
                builder.Append("'/></body></html>");
                Console.WriteLine(builder.ToString());
            }

        }

       
    }
}
