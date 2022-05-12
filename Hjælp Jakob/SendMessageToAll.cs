using System;
using System.Collections.Generic;
using System.Text;

namespace Hjælp_Jakob
{
    public class SendMessageToAll
    {
        ConvertToHTML convertToHTML = new ConvertToHTML();
        public void sendMessageToAll(MessageCarrier type, string[] to, Message m, bool isHTML)
        {
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
