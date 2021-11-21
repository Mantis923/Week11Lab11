using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11Lab11
{
    class Email:Document
    {
        private string title1;

       public string Gettitle()
        {
            return title1;
        }

        public void Settitle(string value)
        {
            title1 = value;
        }

        private string sender;

        public string GetSender()
        {
            return sender;
        }

       public void SetSender(string value)
        {
            sender = value;
        }

      private string recipient;

        public string GetRecipient()
        {
            return recipient;
        }

       public void SetRecipient(string value)
        {
            recipient = value;
        }

        public override string ToString() {


            return "The title is " + Gettitle() + " The sender is " + GetSender()
                + " The recipient is " + GetRecipient() + " The text body is " + GetText();
        }


    }
}
