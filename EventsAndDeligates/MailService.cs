using System;

namespace EventsAndDeligates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Mailservice: sending a eMail...");
        }
    }
}
