using System;

namespace EventsAndDeligates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Mailservice: sending a eMail..." + args.Video.Title);
        }
    }
}
