using System;
using System.Collections.Generic;
using System.Text;

namespace Hjælp_Jakob
{
    class SendMessage
    {
        public void sendMessage(MessageCarrier type, Message m, bool isHTML)
        {
            ConvertToHTML convertToHTML = new ConvertToHTML();
            //herinde sendes der en email ud til modtageren
            if (type.Equals(MessageCarrier.Smtp))
            {
                if (isHTML)
                    m.Body = convertToHTML.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via Smtp
            }

            if (type.Equals(MessageCarrier.VMessage))
            {
                if (isHTML)
                    m.Body = convertToHTML.ConvertBodyToHTML(m.Body);
                //her implementeres alt koden til at sende via VMessage
            }
        }
    }
}
