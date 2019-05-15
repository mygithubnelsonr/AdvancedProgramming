using System;

namespace ExeptionHandling
{
    public class YoutubeExeption : Exception
    {
        public YoutubeExeption(string message, Exception innerexeption)
            : base(message, innerexeption)
        {
        }
    }
}
