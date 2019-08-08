using System;

namespace EventsAndDeligates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Gladiator" };
            var videoencoder = new VideoEncoder();     // publisher
            var mailService = new MailService();       // subscriber
            var messageService = new MessageService(); // subscriber

            videoencoder.VideoEncoded += mailService.OnVideoEncoded;
            videoencoder.VideoEncoded += messageService.OnVideoEncoded;

            videoencoder.Encode(video);
#if DEBUG
            Console.WriteLine("press any key to finish");
            Console.ReadKey();
#endif
        }
    }
}
