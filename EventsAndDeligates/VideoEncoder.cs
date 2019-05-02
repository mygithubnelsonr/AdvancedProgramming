using System;
using System.Threading;

namespace EventsAndDeligates
{
    // custum class for VideoEvents
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // 1. define a deligate
        // 2. define a event based on the delegate
        // 3. raise the event

        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        // replaced with System.EventHandler

        // public event VideoEncodedEventHandler VideoEncoded;
        // replaced with SystemEventHandler

        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);

        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
        }

    }
}
