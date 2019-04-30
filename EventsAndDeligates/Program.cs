using System;

namespace EventsAndDeligates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoencoder = new VideoEncoder();  // publisher
            var mailService = new MailService();    // subscriber

            videoencoder.VideoEncoded += mailService.OnVideoEncoded;
            videoencoder.Encode(video);

#if DEBUG
            Console.WriteLine("press any key to finish");
            Console.ReadKey();
#endif

        }
    }


}
