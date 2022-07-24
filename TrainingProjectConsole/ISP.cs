using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    //I: Interface Segregation Principle (ISP)
    //ISP says clients should not be forced to implement interfaces they don’t use.
    //So instead of huge interfaces, it is better to create multiple small ones so that
    //they are utilized in the best possible way.

    interface iTextMessage
    {
        void TextMessaging(string content);
    }

    interface iWhatsupText
    {
        void WhatsappText(string content);
    }

    interface iVideocall
    {
        void VideoCall(string content);
    }

    class Iphone6s : iTextMessage, iWhatsupText, iVideocall
    {
        public void TextMessaging(string content)
        {
            //Text message done
        }
        public void WhatsappText(string content)
        {
            //WhatsappText done
        }
        public void VideoCall(string content)
        {
            //VideoCall done
        }
    }

    class Nokia1100 : iTextMessage
    {
        public void TextMessaging(string content)
        {
            //Text message done
        }
    }
}
