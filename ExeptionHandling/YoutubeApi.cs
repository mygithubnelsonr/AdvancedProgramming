using System;
using System.Collections.Generic;

namespace ExeptionHandling
{
    public class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // access youtube web service
                // read the data
                // create a list of video objects

                throw new Exception("Ooops, some low level YouTube error.");


            }
            catch (Exception ex)
            {
                // Log
                throw new YoutubeExeption("could not fetch the videos from Youtube.", ex);
            }

            return new List<Video>();

        }
    }
}
